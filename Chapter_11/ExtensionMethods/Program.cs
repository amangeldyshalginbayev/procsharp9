using System;
using System.Data;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with extension methods *****");
            
            InitialExtensionMethodExample();

            Console.ReadLine();
        }

        static void InitialExtensionMethodExample()
        {
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            DataSet d = new DataSet();
            d.DisplayDefiningAssembly();

            Console.WriteLine($"Value of myInt: {myInt}");
            Console.WriteLine($"Reversed digits of myInt: {myInt.ReverseDigits()}");
        }
    }
}