using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreKerOS.System
{
    public static class WriteMessange
    {
        public static void WriteError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Error] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(error);
        }
        public static void WriteWarn(string waring)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[Warning] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(waring);
        }
        public static void WriteInfo(string info)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[Info] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(info);
        }
        public static void WriteOk(string Ok)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Ok] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Ok);
        }
    }
}
