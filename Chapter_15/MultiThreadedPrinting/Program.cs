﻿using System;
using System.Threading;

namespace MultiThreadedPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrencyIssueExample();
            
            
            
            Console.ReadLine();
        }

        static void ConcurrencyIssueExample()
        {
            Console.WriteLine("***** Synchronizing Threads *****\n");

            Printer p = new Printer();

            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = $"Worker thread #{i}"
                };
            }

            foreach (var t in threads)
            {
                t.Start();
            }
        }
    }
}