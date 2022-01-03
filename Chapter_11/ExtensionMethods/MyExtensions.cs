using System;
using System.Reflection;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine($"{obj.GetType().Name} lives here => {Assembly.GetAssembly(obj.GetType()).GetName().Name}");
        }

        public static int ReverseDigits(this int number)
        {
            char[] digits = number.ToString().ToCharArray();
            
            Array.Reverse(digits);

            string newDigits = new string(digits);

            return int.Parse(newDigits);
        }
    }
}