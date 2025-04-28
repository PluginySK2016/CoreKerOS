using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CoreKerOS.System;
using Cosmos.System.FileSystem;
using Sys = Cosmos.System;

namespace CoreKerOS
{
    public class Kernel : Sys.Kernel
    {
        public static string Version = "1.0.0";
        public static string Path = @"0:\";
        public static string Network_version = "0.1.1";
        public static CosmosVFS fs;
        public static bool RunGui;
        int lastHeapCollect;
        protected override void BeforeRun()
        {
            Console.SetWindowSize(90, 30);
            Console.OutputEncoding = Cosmos.System.ExtendedASCII.CosmosEncodingProvider.Instance.GetEncoding(437);
            fs = new Cosmos.System.FileSystem.CosmosVFS();
            Cosmos.System.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.ForegroundColor = ConsoleColor.Cyan;
            WriteMessange.WriteOk("Network");
            Thread.Sleep(2000);
            WriteMessange.WriteOk("Network Version " + Network_version);
            Thread.Sleep(3000);
            WriteMessange.WriteOk("Commands");
            Thread.Sleep(3000);
            WriteMessange.WriteOk("Kernel");
            Thread.Sleep(3000);
            WriteMessange.WriteOk("CoreKerOS");
            Thread.Sleep(3000);
            Console.WriteLine("Booting CoreKerOS " + Version);
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected override void Run()
        {
            Console.Write(Path + ">");
            var command = Console.ReadLine();
            ConsoleCommand.RunCommand(command);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
