using System;
using System.Threading;

namespace ThreadStats
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowPrimaryThreadStats();

            Console.ReadLine();
        }

        static void ShowPrimaryThreadStats()
        {
            Console.WriteLine("***** Primary Thread stats *****");
            
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            Console.WriteLine($"ID of current thread: {primaryThread.ManagedThreadId}");
            Console.WriteLine($"Thread Name: {primaryThread.Name}");
            Console.WriteLine($"Has thread started: {primaryThread.IsAlive}");
            Console.WriteLine($"Priority Level: {primaryThread.Priority}");
            Console.WriteLine($"Thread State: {primaryThread.ThreadState}");
        }
    }
}