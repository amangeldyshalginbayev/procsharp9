using System;
using System.Threading;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Timer type *****\n");

            TimerCallback timeCB = new TimerCallback(PrintTime);
            Timer timer = new Timer(timeCB,"Hello from C# 9",0,1000);
            Console.WriteLine("Hit Enter key to terminate...");
            

            Console.ReadLine();


        }

        static void PrintTime(object state)
        {
            Console.WriteLine($"Time is: {DateTime.Now.ToLongTimeString()}, Param is: {state}");
        }
    }
}