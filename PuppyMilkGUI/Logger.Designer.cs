namespace PuppyMilkGUI
{
	// Token: 0x02000003 RID: 3
	public partial class Logger : global::System.Windows.Forms.Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x0000360C File Offset: 0x0000180C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003644 File Offset: 0x00001844
		private void InitializeComponent()
		{
			this.LogBox = new global::System.Windows.Forms.RichTextBox();
			this.SaveLogBtn = new global::System.Windows.Forms.Button();
			this.ClearLogBtn = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.LogBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.LogBox.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.LogBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.LogBox.ForeColor = global::System.Drawing.Color.White;
			this.LogBox.Location = new global::System.Drawing.Point(0, 0);
			this.LogBox.Name = "LogBox";
			this.LogBox.ReadOnly = true;
			this.LogBox.Size = new global::System.Drawing.Size(304, 239);
			this.LogBox.TabIndex = 0;
			this.LogBox.Text = "";
			this.SaveLogBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.SaveLogBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SaveLogBtn.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.SaveLogBtn.ForeColor = global::System.Drawing.Color.White;
			this.SaveLogBtn.Location = new global::System.Drawing.Point(255, 245);
			this.SaveLogBtn.Name = "SaveLogBtn";
			this.SaveLogBtn.Size = new global::System.Drawing.Size(46, 23);
			this.SaveLogBtn.TabIndex = 8;
			this.SaveLogBtn.Text = "Save";
			this.SaveLogBtn.UseVisualStyleBackColor = true;
			this.SaveLogBtn.Click += new global::System.EventHandler(this.SaveLogBtn_Click);
			this.ClearLogBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.ClearLogBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ClearLogBtn.Font = new global::System.Drawing.Font("Consolas", 9f);
			this.ClearLogBtn.ForeColor = global::System.Drawing.Color.White;
			this.ClearLogBtn.Location = new global::System.Drawing.Point(3, 245);
			this.ClearLogBtn.Name = "ClearLogBtn";
			this.ClearLogBtn.Size = new global::System.Drawing.Size(54, 23);
			this.ClearLogBtn.TabIndex = 9;
			this.ClearLogBtn.Text = "Clear";
			this.ClearLogBtn.UseVisualStyleBackColor = true;
			this.ClearLogBtn.Click += new global::System.EventHandler(this.ClearLogBtn_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(304, 271);
			base.Controls.Add(this.ClearLogBtn);
			base.Controls.Add(this.SaveLogBtn);
			base.Controls.Add(this.LogBox);
			this.Font = new global::System.Drawing.Font("Consolas", 8f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new global::System.Drawing.Size(320, 310);
			base.Name = "Logger";
			this.Text = "Logger";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Logger_FormClosing);
			base.ResumeLayout(false);
		}

		// Token: 0x04000015 RID: 21
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000016 RID: 22
		protected global::System.Windows.Forms.RichTextBox LogBox;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button SaveLogBtn;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button ClearLogBtn;
	}
}
