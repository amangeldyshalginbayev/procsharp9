using System;
using System.Collections.Generic;

namespace InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Extending interface compatible types *****");

            InitialExample();

            Console.ReadLine();
        }

        static void InitialExample()
        {
            string[] data = { "bla", "bla", "some", "random", "text", "yo" };

            data.PrintDataAndBeep();

            Console.WriteLine();

            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.PrintDataAndBeep();
        }
    }
}