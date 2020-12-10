using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PuppyMilkGUI
{
	// Token: 0x02000003 RID: 3
	public partial class Logger : Form
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000035A8 File Offset: 0x000017A8
		public Logger()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000035C0 File Offset: 0x000017C0
		private void Logger_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000035D2 File Offset: 0x000017D2
		private void SaveLogBtn_Click(object sender, EventArgs e)
		{
			File.WriteAllText(string.Format("puppywrap-{0}.log", DateTime.Now), this.LogBox.Text);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000035FA File Offset: 0x000017FA
		private void ClearLogBtn_Click(object sender, EventArgs e)
		{
			this.LogBox.Clear();
		}
	}
}
