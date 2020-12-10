namespace PuppyMilkGUI
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002874 File Offset: 0x00000A74
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000028AC File Offset: 0x00000AAC
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.DllList = new global::System.Windows.Forms.DataGridView();
			this.selectedCol = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.extFpCol = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddDllsBtn = new global::System.Windows.Forms.Button();
			this.RemoveDllsBtn = new global::System.Windows.Forms.Button();
			this.DllSelector = new global::System.Windows.Forms.OpenFileDialog();
			this.BlockGameStatusTxt = new global::System.Windows.Forms.Label();
			this.InjectBtn = new global::System.Windows.Forms.Button();
			this.LogSHBtn = new global::System.Windows.Forms.Button();
			this.AutoLoadCheck = new global::System.Windows.Forms.CheckBox();
			this.PuppyPathBox = new global::System.Windows.Forms.TextBox();
			this.DLPuppyBtn = new global::System.Windows.Forms.Button();
			this.FindPuppyBtn = new global::System.Windows.Forms.Button();
			this.PuppySelector = new global::System.Windows.Forms.OpenFileDialog();
			this.TopMostCheck = new global::System.Windows.Forms.CheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.DllList).BeginInit();
			base.SuspendLayout();
			this.DllList.AllowUserToAddRows = false;
			this.DllList.AllowUserToDeleteRows = false;
			this.DllList.AllowUserToResizeRows = false;
			this.DllList.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.DllList.BackgroundColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DllList.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Consolas", 9f);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DllList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DllList.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DllList.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.selectedCol,
				this.extFpCol
			});
			this.DllList.GridColor = global::System.Drawing.Color.White;
			this.DllList.Location = new global::System.Drawing.Point(12, 54);
			this.DllList.Name = "DllList";
			this.DllList.RowHeadersVisible = false;
			this.DllList.Size = new global::System.Drawing.Size(387, 180);
			this.DllList.TabIndex = 1;
			this.selectedCol.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle5.NullValue = false;
			this.selectedCol.DefaultCellStyle = dataGridViewCellStyle5;
			this.selectedCol.HeaderText = "Checked";
			this.selectedCol.MinimumWidth = 17;
			this.selectedCol.Name = "selectedCol";
			this.selectedCol.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.selectedCol.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.selectedCol.ToolTipText = "Selected Dll(s) Column";
			this.selectedCol.Width = 79;
			this.extFpCol.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle6.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			dataGridViewCellStyle6.ForeColor = global::System.Drawing.Color.White;
			this.extFpCol.DefaultCellStyle = dataGridViewCellStyle6;
			this.extFpCol.HeaderText = "DLL";
			this.extFpCol.MinimumWidth = 75;
			this.extFpCol.Name = "extFpCol";
			this.extFpCol.ReadOnly = true;
			this.AddDllsBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.AddDllsBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.AddDllsBtn.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.AddDllsBtn.ForeColor = global::System.Drawing.Color.White;
			this.AddDllsBtn.Location = new global::System.Drawing.Point(405, 54);
			this.AddDllsBtn.Name = "AddDllsBtn";
			this.AddDllsBtn.Size = new global::System.Drawing.Size(23, 23);
			this.AddDllsBtn.TabIndex = 3;
			this.AddDllsBtn.Text = "+";
			this.AddDllsBtn.UseVisualStyleBackColor = true;
			this.AddDllsBtn.Click += new global::System.EventHandler(this.AddDllsBtn_Click);
			this.RemoveDllsBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.RemoveDllsBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.RemoveDllsBtn.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.RemoveDllsBtn.ForeColor = global::System.Drawing.Color.White;
			this.RemoveDllsBtn.Location = new global::System.Drawing.Point(405, 83);
			this.RemoveDllsBtn.Name = "RemoveDllsBtn";
			this.RemoveDllsBtn.Size = new global::System.Drawing.Size(23, 23);
			this.RemoveDllsBtn.TabIndex = 4;
			this.RemoveDllsBtn.Text = "-";
			this.RemoveDllsBtn.UseVisualStyleBackColor = true;
			this.RemoveDllsBtn.Click += new global::System.EventHandler(this.RemoveDllsBtn_Click);
			this.DllSelector.DefaultExt = "dll";
			this.DllSelector.FileName = "KaguyaLol";
			this.DllSelector.Filter = "Dynamic Link Library|*.dll|All files|*.*";
			this.DllSelector.Multiselect = true;
			this.DllSelector.Title = "Select Dll(s) to Add";
			this.BlockGameStatusTxt.AutoSize = true;
			this.BlockGameStatusTxt.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.BlockGameStatusTxt.ForeColor = global::System.Drawing.Color.White;
			this.BlockGameStatusTxt.Location = new global::System.Drawing.Point(9, 9);
			this.BlockGameStatusTxt.Name = "BlockGameStatusTxt";
			this.BlockGameStatusTxt.Size = new global::System.Drawing.Size(154, 14);
			this.BlockGameStatusTxt.TabIndex = 5;
			this.BlockGameStatusTxt.Text = "Block Game: Not Ready";
			this.InjectBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.InjectBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.InjectBtn.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.InjectBtn.ForeColor = global::System.Drawing.Color.White;
			this.InjectBtn.Location = new global::System.Drawing.Point(12, 240);
			this.InjectBtn.Name = "InjectBtn";
			this.InjectBtn.Size = new global::System.Drawing.Size(95, 23);
			this.InjectBtn.TabIndex = 6;
			this.InjectBtn.Text = "Load DLL(s)";
			this.InjectBtn.UseVisualStyleBackColor = true;
			this.InjectBtn.Click += new global::System.EventHandler(this.InjectBtn_Click);
			this.LogSHBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.LogSHBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LogSHBtn.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.LogSHBtn.ForeColor = global::System.Drawing.Color.White;
			this.LogSHBtn.Location = new global::System.Drawing.Point(325, 240);
			this.LogSHBtn.Name = "LogSHBtn";
			this.LogSHBtn.Size = new global::System.Drawing.Size(74, 23);
			this.LogSHBtn.TabIndex = 7;
			this.LogSHBtn.Text = "Show Log";
			this.LogSHBtn.UseVisualStyleBackColor = true;
			this.LogSHBtn.Click += new global::System.EventHandler(this.LogSHBtn_Click);
			this.AutoLoadCheck.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.AutoLoadCheck.AutoSize = true;
			this.AutoLoadCheck.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.AutoLoadCheck.ForeColor = global::System.Drawing.Color.White;
			this.AutoLoadCheck.Location = new global::System.Drawing.Point(339, 5);
			this.AutoLoadCheck.Name = "AutoLoadCheck";
			this.AutoLoadCheck.Size = new global::System.Drawing.Size(89, 18);
			this.AutoLoadCheck.TabIndex = 8;
			this.AutoLoadCheck.Text = "Auto Load";
			this.AutoLoadCheck.UseVisualStyleBackColor = true;
			this.AutoLoadCheck.CheckedChanged += new global::System.EventHandler(this.AutoLoadCheck_CheckedChanged);
			this.PuppyPathBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.PuppyPathBox.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.PuppyPathBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.PuppyPathBox.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.PuppyPathBox.ForeColor = global::System.Drawing.Color.White;
			this.PuppyPathBox.Location = new global::System.Drawing.Point(12, 26);
			this.PuppyPathBox.Name = "PuppyPathBox";
			this.PuppyPathBox.Size = new global::System.Drawing.Size(284, 22);
			this.PuppyPathBox.TabIndex = 9;
			this.PuppyPathBox.Text = "Puppy Injector Executable Path Here";
			this.DLPuppyBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.DLPuppyBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.DLPuppyBtn.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.DLPuppyBtn.ForeColor = global::System.Drawing.Color.White;
			this.DLPuppyBtn.Location = new global::System.Drawing.Point(353, 25);
			this.DLPuppyBtn.Name = "DLPuppyBtn";
			this.DLPuppyBtn.Size = new global::System.Drawing.Size(75, 23);
			this.DLPuppyBtn.TabIndex = 10;
			this.DLPuppyBtn.Text = "Download";
			this.DLPuppyBtn.UseVisualStyleBackColor = true;
			this.DLPuppyBtn.Click += new global::System.EventHandler(this.DLPuppyBtn_Click);
			this.FindPuppyBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.FindPuppyBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.FindPuppyBtn.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.FindPuppyBtn.ForeColor = global::System.Drawing.Color.White;
			this.FindPuppyBtn.Location = new global::System.Drawing.Point(302, 25);
			this.FindPuppyBtn.Name = "FindPuppyBtn";
			this.FindPuppyBtn.Size = new global::System.Drawing.Size(45, 23);
			this.FindPuppyBtn.TabIndex = 11;
			this.FindPuppyBtn.Text = "Find";
			this.FindPuppyBtn.UseVisualStyleBackColor = true;
			this.FindPuppyBtn.Click += new global::System.EventHandler(this.FindPuppyBtn_Click);
			this.PuppySelector.DefaultExt = "exe";
			this.PuppySelector.FileName = "PuppyLol";
			this.PuppySelector.Filter = "Executable File|*.exe";
			this.PuppySelector.Title = "Select Puppy Injector";
			this.TopMostCheck.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.TopMostCheck.AutoSize = true;
			this.TopMostCheck.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.TopMostCheck.ForeColor = global::System.Drawing.Color.White;
			this.TopMostCheck.Location = new global::System.Drawing.Point(202, 243);
			this.TopMostCheck.Name = "TopMostCheck";
			this.TopMostCheck.Size = new global::System.Drawing.Size(117, 18);
			this.TopMostCheck.TabIndex = 12;
			this.TopMostCheck.Text = "Always On Top";
			this.TopMostCheck.UseVisualStyleBackColor = true;
			this.TopMostCheck.CheckedChanged += new global::System.EventHandler(this.TopMostCheck_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			base.ClientSize = new global::System.Drawing.Size(434, 271);
			base.Controls.Add(this.TopMostCheck);
			base.Controls.Add(this.FindPuppyBtn);
			base.Controls.Add(this.DLPuppyBtn);
			base.Controls.Add(this.PuppyPathBox);
			base.Controls.Add(this.AutoLoadCheck);
			base.Controls.Add(this.LogSHBtn);
			base.Controls.Add(this.InjectBtn);
			base.Controls.Add(this.BlockGameStatusTxt);
			base.Controls.Add(this.RemoveDllsBtn);
			base.Controls.Add(this.AddDllsBtn);
			base.Controls.Add(this.DllList);
			this.MinimumSize = new global::System.Drawing.Size(450, 310);
			base.Name = "Form1";
			this.Text = "PuppyMilkWrapper GUI";
			((global::System.ComponentModel.ISupportInitialize)this.DllList).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000005 RID: 5
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.DataGridView DllList;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button AddDllsBtn;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button RemoveDllsBtn;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.OpenFileDialog DllSelector;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn selectedCol;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.DataGridViewTextBoxColumn extFpCol;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label BlockGameStatusTxt;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button InjectBtn;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button LogSHBtn;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.CheckBox AutoLoadCheck;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.TextBox PuppyPathBox;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button DLPuppyBtn;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button FindPuppyBtn;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.OpenFileDialog PuppySelector;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.CheckBox TopMostCheck;
	}
}
