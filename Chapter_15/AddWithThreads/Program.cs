using System;
using System.Threading;

namespace AddWithThreads
{
    class Program
    {
        private static AutoResetEvent _waitHandle = new AutoResetEvent(false);
        
        static void Main(string[] args)
        {
            //AddWithThreads();
            BackGroundThreadExample();
            
            //Console.ReadLine();
        }

        static void Add(object data)
        {
            if (data is AddParams ap)
            {
                Console.WriteLine($"ID of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");

                Console.WriteLine($"{ap.a} + {ap.b} is {ap.a + ap.b}");

                Console.WriteLine("Check point 1 in Add()");
                // Tell other thread we are done
                _waitHandle.Set();

                Console.WriteLine("Check point 2 in Add()");
            }
        }

        static void AddWithThreads()
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine($"ID of thread in Main(): {Thread.CurrentThread.ManagedThreadId}");

            // Make AddParams object to pass to the method that is executed in the secondary thread
            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);
            
            // Wait until the secondary thread finishes
            //Thread.Sleep(9000);
            
            // wait here until you are notified!
            _waitHandle.WaitOne();
            Console.WriteLine("Now main is awake!");
        }

        static void BackGroundThreadExample()
        {
            Console.WriteLine("***** Background Threads *****\n");
            Printer p = new Printer();
            Thread bgroundThread = new Thread(new ThreadStart(p.PrintNumbers));

            bgroundThread.IsBackground = true;
            bgroundThread.Start();
        }
    }
}