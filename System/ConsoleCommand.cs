using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreKerOS.System
{
    public static class ConsoleCommand
    {
        public static void RunCommand(string command)
        {
            string[] words = command.Split(' ');
            if(words.Length > 0)
            {
                if (words[0] == "info")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("CoreKerOS " + Kernel.Version);
                    Console.WriteLine("Created by Adam");
                    Console.WriteLine("https://www.youtube.com/@X_LikeMC_X");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
                else if (words[0] == "format")
                {
                    if (Kernel.fs.Disks[0].Partitions.Count > 0)
                    {
                        Kernel.fs.Disks[0].DeletePartition(0);
                    }
                    Kernel.fs.Disks[0].Clear();
                    Kernel.fs.Disks[0].CreatePartition(0);
                    Kernel.fs.Disks[0].FormatPartition(0, "FAT32", true);
                    WriteMessange.WriteOk("Success!");
                    WriteMessange.WriteWarn("CoreKerOS will reboot in 3 seconds!");
                    Thread.Sleep(3000);
                    Cosmos.System.Power.Reboot();
                }
                else if (words[0] == "space")
                {
                    long free = Kernel.fs.GetAvailableFreeSpace(Kernel.Path);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    WriteMessange.WriteInfo("Free Sprace: " + free / 1024 + "KB");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (words[0] == "shutdown")
                {
                    WriteMessange.WriteWarn("CoreKerOS will shutdown in 3 seconds!");
                    Thread.Sleep(3000);
                    Cosmos.System.Power.Shutdown();
                }
                else if (words[0] == "reboot")
                {
                    WriteMessange.WriteWarn("CoreKerOS will reboot in 3 seconds!");
                    Thread.Sleep(3000);
                    Cosmos.System.Power.Reboot();
                }
                else if (words[0] == "help")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Commands: info, space, shutdown, reboot, help");
                    Console.WriteLine();
                    Console.WriteLine("Author: Adam");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (words[0] == "gui")
            {
                Boot.onBoot();
            }
            else
            {
                WriteMessange.WriteError("Plese enter a valid command");
            }
        }
    }
}
