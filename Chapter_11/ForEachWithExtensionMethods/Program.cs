using System;

namespace ForEachWithExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Support for extension method GetEnumerator *****");
            Garage carLot = new Garage();

            foreach (Car car in carLot)
            {
                Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH");
            }
        }
    }
}