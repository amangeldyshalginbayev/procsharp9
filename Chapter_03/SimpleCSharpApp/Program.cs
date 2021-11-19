using System;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            
            // Process any incoming args.
            // for (int i = 0; i < args.Length; i++)
            // {
            //     Console.WriteLine("Arg: {0}", args[i]);
            // }
            
            // Get arguments using System.Environment.
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (var arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }
            
            // Local method within the Top-level statements.
            ShowEnvironmentDetails();
            
            // Wait for Enter key to be pressed before shutting down.
            Console.ReadLine();
            
            // Return an arbitrary error code.
            return 0;
        }

        static void ShowEnvironmentDetails()
        {
            foreach (var drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Core Version: {0}", Environment.Version);
        }
    }
}