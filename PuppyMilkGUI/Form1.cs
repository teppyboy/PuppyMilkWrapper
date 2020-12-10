using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuppyMilkWrapper;

namespace PuppyMilkGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Log("PuppyMilkWrapper Initialized!");
			Task.Run(MkChk);
			Log("Started Background Task");
			Console.SetOut(new InterceptingWriter(Console.Out, (str) => Log(str)));
		}
		class InterceptingWriter : TextWriter
		{
			readonly TextWriter _existingWriter;
			readonly Action<string> _writeTask;

			public InterceptingWriter(TextWriter existing, Action<string> task)
			{
				_existingWriter = existing;
				_writeTask = task;
			}

			public override void WriteLine(string value)
			{
				_existingWriter.WriteLine(value);
				_writeTask(value);
			}

			public override Encoding Encoding
			{
				get { throw new NotImplementedException(); }
			}
		}
		private bool FindBlockProcess()
		{
			foreach (Process BlockGame in Process.GetProcessesByName("RobloxPlayerBeta"))
			{
				bool flag = BlockGame.MainWindowHandle != IntPtr.Zero;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}
		private Task MkChk()
		{
			while (true)
			{
				if (FindBlockProcess())
				{
					BlockGameStatusTxt.Text = "Block Game: Ready";
					if (AutoLoadCheck.Checked)
					{
						LoadLDRLol();
					}
				}
				else
				{
					BlockGameStatusTxt.Text = "Block Game: Not Ready";
					if (WrappedDLLs.Count > 0)
					{
						WrappedDLLs.Clear();
						Log("Cleared Injected DLL list");
					}
				}
				Task.Delay(100).Wait();
			}
		}
		private void AddDllsBtn_Click(object sender, EventArgs e)
		{
			bool flag = DllSelector.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				foreach (string File in DllSelector.FileNames)
				{
					int newRow = DllList.Rows.Add();
					DllList.Rows[newRow].Cells[0].Value = false;
					DllList.Rows[newRow].Cells[1].Value = File;
				}
			}
		}
		private void LoadLDRLol()
		{
			if (File.Exists(PuppyPathBox.Text))
			{
				foreach (DataGridViewRow DllRow in DllList.Rows.Cast<DataGridViewRow>().ToArray())
				{
					string Dll = (string)DllRow.Cells[1].Value;
					if ((bool)DllRow.Cells[0].Value && !WrappedDLLs.Contains(Dll))
					{
						Log("Calling PuppyMilk to load DLL\nPlease patient because bypassed load takes longer than normal.");
						PuppyInjector.Inject(Dll);
						WrappedDLLs.Add(Dll);
						Log("Added DLL to Loaded DLL List");
					}
				}
			}
		}
		private void RemoveDllsBtn_Click(object sender, EventArgs e)
		{
			foreach (object obj in DllList.SelectedCells)
			{
				DataGridViewCell Item = (DataGridViewCell)obj;
				DllList.Rows.RemoveAt(Item.RowIndex);
			}
		}

		private void Log(string format, params object[] obj)
		{
			foreach (object Control in Logger.Controls)
			{
				if (Control is RichTextBox box)
				{
					box.AppendText(string.Format(format, obj) + Environment.NewLine);
					break;
				}
			}
		}
		private void LogSHBtn_Click(object sender, EventArgs e)
		{
			if (!Logger.Visible)
			{
				Logger.Show();
				Logger.Location = new Point(Location.X + Size.Width + 5, Location.Y);
				Logger.Size = new Size(Logger.Width, Height);
				LogSHBtn.Text = "Hide Log";
				Logger.VisibleChanged += Logger_VisibleChanged;
			}
			else
			{
				Logger.Hide();
				LogSHBtn.Text = "Show Log";
			}
		}
		private void Logger_VisibleChanged(object sender, EventArgs e)
		{
			LogSHBtn.Text = "Show Log";
			Logger.VisibleChanged -= Logger_VisibleChanged;
		}
		private void AutoLoadCheck_CheckedChanged(object sender, EventArgs e)
		{
			Log("Auto Load status: {0}", AutoLoadCheck.Checked);
			InjectBtn.Enabled = !AutoLoadCheck.Checked;
		}
		private void FindPuppyBtn_Click(object sender, EventArgs e)
		{
			Log("Begin select PuppyMilk path");
			bool flag = PuppySelector.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				Log("PuppyMilk path: {0}", PuppySelector.FileName);
				PuppyPathBox.Text = PuppySelector.FileName;
				PuppyInjector.PuppyMilkPath = PuppyPathBox.Text;
			}
			else
			{
				Log("User cancelled the selection.");
			}
		}
		private void DLPuppyBtn_Click(object sender, EventArgs e)
		{
			Log("[WARN] DLPuppy is not implemented.");
			MessageBox.Show("Not Implemented.", "PuppyMilkWrapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		private void InjectBtn_Click(object sender, EventArgs e)
		{
			InjectBtn.Enabled = false;
			AutoLoadCheck.Enabled = false;
			Task.Run(LoadLDRLol);
			InjectBtn.Enabled = true;
			AutoLoadCheck.Enabled = true;
		}
		private void TopMostCheck_CheckedChanged(object sender, EventArgs e)
		{
			TopMost = TopMostCheck.Checked;
			Logger.TopMost = TopMostCheck.Checked;
		}

		public Form Logger = new Logger();
		public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
		private readonly List<string> WrappedDLLs = new List<string>();
	}
}
