using System;
using System.Diagnostics;
using System.IO;

namespace PuppyMilkWrapper
{
    public class PuppyInjector
    {
		/// <summary>
		/// Set the Puppy Milk Injector path (default is null). May deprecate in the future
		/// </summary>
		/// <param name="PuppyMilkPath"></param>
		public static string PuppyMilkPath = null;
		private static string PuppyOutput = "";
		private static void PuppyMilk_DataReceived(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(e.Data))
			{
				PuppyLogger.Debug("PuppyMilk Log: {0}", e.Data);
				PuppyOutput = PuppyOutput + e.Data + Environment.NewLine;
			}
		}
		/// <summary>
		/// Inject the file provided by [dllPath] to Block Game
		/// </summary>
		/// <param name="dllPath"></param>
		public static void Inject(string dllPath)
		{
			if (string.IsNullOrWhiteSpace(PuppyMilkPath))
            {
				throw new InvalidDataException("PuppyMilkPath isn't set. Have you set this correctly?\nUse PuppyInjector.PuppyMilkPath = [path here] to set.");
            }
			PuppyLogger.Debug("DLL: {0}", dllPath);
			if (File.Exists(dllPath))
			{
				PuppyLogger.Debug("DLL Exists!");
				PuppyLogger.Debug("Begin start PuppyMilk...");
				bool NoWindow = true;
				ProcessWindowStyle processWindowStyle = ProcessWindowStyle.Hidden;
				if ((int)PuppyLogger.PuppyLogLevel <= 0)
                {
					NoWindow = false;
					processWindowStyle = ProcessWindowStyle.Normal;
                }
				PuppyLogger.Debug("CreateNoWindow: {0} | ProcessWindowStyle: {1}", NoWindow, processWindowStyle);
				long StartTime = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
				using (Process PuppyMilk = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = PuppyMilkPath,
						Arguments = "\"" + dllPath + "\"",
						CreateNoWindow = NoWindow,
						WindowStyle = processWindowStyle,
						UseShellExecute = false,
						RedirectStandardError = true,
						RedirectStandardOutput = true
					}
				})
				{
					PuppyMilk.ErrorDataReceived += PuppyMilk_DataReceived;
					PuppyMilk.OutputDataReceived += PuppyMilk_DataReceived;
					PuppyMilk.Start();
					PuppyOutput = "";
					PuppyMilk.BeginErrorReadLine();
					PuppyMilk.BeginOutputReadLine();
					PuppyMilk.WaitForExit();
					if (PuppyOutput.Contains("Done!"))
					{
						PuppyLogger.Debug("Sucessfully Load DLL [{0}]", dllPath);
					}
					else
					{
						PuppyLogger.Error("Unknown case, probably Load DLL [{0}] failed", dllPath);
						throw new AccessViolationException(string.Format("DLL [{0}] failed to inject to Block Game\nLog:\n{1}", dllPath, PuppyOutput));
					}
					PuppyLogger.Debug("Load DLL time: {0}ms", ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds() - StartTime);
				}
			}
            else
            {
				var msg = string.Format("The DLL [{0}] isn't found.", dllPath);
				PuppyLogger.Error(msg);
				throw new FileNotFoundException(msg);
            }
		}
	}
}
