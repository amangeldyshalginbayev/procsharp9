using System;
using System.Collections;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IEnumerable/IEnumerator *****\n");
            Garage carLot = new Garage();

            foreach (Car c in carLot)
            {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH.");
            }

            IEnumerator carEnumerator = carLot.GetEnumerator();
            carEnumerator.MoveNext();
            Car myCar = (Car)carEnumerator.Current;
            Console.WriteLine($"{myCar.PetName} is going {myCar.CurrentSpeed}.");

            Console.ReadLine();
        }
    }
}