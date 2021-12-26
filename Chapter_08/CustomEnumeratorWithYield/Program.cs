using System;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Yield Keyword *****\n");
            // Garage carLot = new Garage();
            // IEnumerator carEnumerator = carLot.GetEnumerator();
            //
            // Console.WriteLine(carEnumerator.GetType().Name);

            Garage carLot = new Garage();
            // try
            // {
            //     var carEnumerator = carLot.GetEnumerator();
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Exception occured on GetEnumerator()");
            // }

            foreach (Car car in carLot)
            {
                Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH.");
            }

            // get items in reverse order
            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH.");
            }

            Console.ReadLine();
        }
    }
}