using System;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with custom generic methods *****");

            int a = 10;
            int b = 90;
            Console.WriteLine($"Before swap a: {a}, b: {b}");
            SwapFunctions.Swap<int>(ref a, ref b);
            Console.WriteLine($"After swap a: {a}, b: {b}");
            Console.WriteLine();
            
            string s1 = "Hello";
            string s2 = "There";
            Console.WriteLine($"Before swap a: {s1}, b: {s2}");
            SwapFunctions.Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After swap a: {s1}, b: {s2}");

            Console.ReadLine();
        }
    }
}