using System;
using System.Diagnostics;
using System.Linq;

namespace ProcessManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with processes *****");
            //ListAllRunningProcesses();
            //GetSpecificProcess();
            //LookForThreadsByPid();
            //EnumModsForPid(3424);
            StartAndKillProcess();

            Console.ReadLine();
        }

        static void ListAllRunningProcesses()
        {
            var runningProcesses = from proc in Process.GetProcesses(".")
                orderby proc.Id
                select proc;

            foreach (var p in runningProcesses)
            {
                Console.WriteLine($"-> PID: {p.Id}, Name: {p.ProcessName}");
            }

            Console.WriteLine("**********\n");
        }

        static void GetSpecificProcess()
        {
            Process process = null;
            try
            {
                process = Process.GetProcessById(816);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void EnumThreadsForPid(int pID)
        {
            Process p = null;
            try
            {
                p = Process.GetProcessById(pID);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine($"Here are the threads used by: {p.ProcessName}");

            try
            {
                ProcessThreadCollection threadCollection = p.Threads;
                foreach (ProcessThread thread in threadCollection)
                {
                    Console.WriteLine(
                        $"-> Thread ID: {thread.Id}\tStart Time: {thread.StartTime.ToShortTimeString()}\tPriority:{thread.PriorityLevel}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("*******************************************\n");
        }

        static void LookForThreadsByPid()
        {
            Console.WriteLine("***** Enter PID of process to investigate *****");
            Console.Write("PID: ");
            string pID = Console.ReadLine();
            int theProcID = int.Parse(pID);

            EnumThreadsForPid(theProcID);
        }

        static void EnumModsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine($"Here are the loaded modules for: {theProc.ProcessName}");
            ProcessModuleCollection theModules = theProc.Modules;
            foreach (ProcessModule pm in theModules)
            {
                Console.WriteLine($"-> Module Name: {pm.ModuleName}");
            }

            Console.WriteLine("*************************************\n");
        }

        static void StartAndKillProcess()
        {
            Process process = null;

            try
            {
                //process = Process.Start("/System/Applications/Utilities/Terminal.app/Contents/MacOS/Terminal");
                ProcessStartInfo startInfo = new ProcessStartInfo("/System/Applications/Utilities/Terminal.app/Contents/MacOS/Terminal");
                startInfo.UseShellExecute = true;
                process = Process.Start(startInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"--> Hit enter to kill {process.ProcessName}");
            Console.ReadLine();

            try
            {
                foreach (var p in Process.GetProcessesByName("Terminal"))
                {
                    p.Kill(true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}