using System;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            // Car myCar = new Car();
            // myCar.petName = "Henry";
            // myCar.currSpeed = 10;
            //
            // for (int i = 0; i <= 10; i++)
            // {
            //     myCar.SpeedUp(5);
            //     myCar.PrintState();
            // }
            //
            // Console.WriteLine();
            // new Car().PrintState();
            //
            // Console.WriteLine();
            // Motorcycle mc = new Motorcycle();
            // mc.PopAWheely();

            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName);
            
            Console.ReadLine();
        }
    }
}