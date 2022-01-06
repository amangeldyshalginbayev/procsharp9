using System;

namespace PublicDelegateProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** No encapsulation! *****");

            Car myCar = new Car();

            myCar.ListOfHandlers = CallWhenExploded;
            myCar.Accelerate(10);

            myCar.ListOfHandlers = CallHereToo;
            myCar.Accelerate(10);

            myCar.ListOfHandlers("I am directly invoking delegate!!!");

            Console.ReadLine();
        }

        static void CallWhenExploded(string msg)
        {
            Console.WriteLine(msg);
        }
        
        static void CallHereToo(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}