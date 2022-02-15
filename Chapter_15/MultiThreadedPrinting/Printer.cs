using System;
using System.Threading;

namespace MultiThreadedPrinting
{
    public class Printer
    {
        private object _threadLock = new object();

        public void PrintNumbers()
        {
            lock (_threadLock)
            {
                Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.Write($"{i}, ");
                }

                Console.WriteLine();
            }
        }
    }
}