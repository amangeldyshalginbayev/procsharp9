using System;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            //Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            //MyMathClass.PI = 3.1444;

            Console.WriteLine($"The value of static read only PI is: {MyMathClass.STATIC_READ_ONLY_PI}");
            Console.ReadLine();
        }

        static void LocalConstStringVariable()
        {
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);

            //fixedStr = "This fails!";
        }
    }
}