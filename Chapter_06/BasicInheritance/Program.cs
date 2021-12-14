using System;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            //
            // Car myCar = new Car(80) { Speed = 50 };
            //
            // Console.WriteLine($"My car is going {myCar.Speed} MPH");

            MiniVan myVan = new MiniVan { Speed = 10 };
            Console.WriteLine($"My vans maximum speed: {myVan.MaxSpeed}");
            Console.WriteLine($"My van is going {myVan.Speed} MPH");

            MiniVan myVan2 = new MiniVan();
            myVan2.Speed = 10;
            Console.WriteLine($"MyVan2 is going {myVan2.Speed} MPH.");
            //myVan2._currSpeed = 55;
                
            Console.ReadLine();
        }
    }
}