using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Hazel
{
    public class Debug
    {

        internal static void DLog(object log)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("DLog " + DateTime.Now + " " + log);
        }

        internal static void DLogWarning(object log)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DLog " + DateTime.Now + " " + log);
        }

        internal static void DLogError(object log)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DLog " + DateTime.Now + " " + log);
            throw new Exception(log.ToString());
        }

        public static void Log(object log)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(DateTime.Now +" "+ log);
        }

        public static void LogWarning(object log)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(DateTime.Now + " " + log);
        }

        public static void LogError(object log)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(DateTime.Now + " " + log);
            throw new Exception(log.ToString());
        }
    }
}
