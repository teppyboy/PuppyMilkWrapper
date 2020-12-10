using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppyMilkWrapper
{
    public class PuppyLogger
    {
        public enum LogLevel
        {
            Verbose,
            Warning,
            Error,
            Disabled
        }
        public static LogLevel PuppyLogLevel = LogLevel.Error;
        public static void Debug(string format, params object[] arg)
        {
            if ((int)PuppyLogLevel <= 0)
            {
                Console.WriteLine("[DEBUG]: " + format, arg);
            }
        }
        public static void Error(string format, params object[] arg)
        {
            if ((int)PuppyLogLevel <= 2)
            {
                Console.WriteLine("[ERROR]: " + format, arg);
            }
        }
        public static void Warning(string format, params object[] arg)
        {
            if ((int)PuppyLogLevel <= 1)
            {
                Console.WriteLine("[WARN]: " + format, arg);
            }
        }
    }
}
