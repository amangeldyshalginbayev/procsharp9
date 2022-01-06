using System;

namespace GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Generic Delegates *****");

            MyGenericDelegate<string> strTarget = StringTarget;
            strTarget("Some string data");
            
            MyGenericDelegate<int> intTarget = IntTarget;
            intTarget(99);

            Console.ReadLine();



        }

        static void StringTarget(string arg)
        {
            Console.WriteLine($"arg in uppercase is: {arg.ToUpper()}");
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine($"++arg is: {++arg}");
        }
    }

    public delegate void MyGenericDelegate<T>(T arg);
}