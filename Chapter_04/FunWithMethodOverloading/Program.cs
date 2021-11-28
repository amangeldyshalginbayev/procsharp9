using System;
using static FunWithMethodOverloading.AddOperations;

namespace FunWithMethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Fun with Method Overloading *****");

            Console.WriteLine(Add(10,10));

            Console.WriteLine(Add(900_000_000_000,900));

            Console.WriteLine(Add(4.3,4.4));

            Console.ReadLine();
        }
    }
}