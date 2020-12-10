using System;
using System.Windows.Forms;

namespace PuppyMilkGUI
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000399C File Offset: 0x00001B9C
		[STAThread]
		private static void Main(string[] args)
		{
			foreach (var arg in args)
            {
				if (arg.ToLower() == "-verbose")
                {
					PuppyMilkWrapper.PuppyLogger.PuppyLogLevel = PuppyMilkWrapper.PuppyLogger.LogLevel.Verbose;
                }
            }
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
