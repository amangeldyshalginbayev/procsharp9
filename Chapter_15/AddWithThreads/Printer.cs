using System;
using System.Threading;

namespace AddWithThreads
{
    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} is executing PrintNumbers()");
            
            Console.Write("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}, ");
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}