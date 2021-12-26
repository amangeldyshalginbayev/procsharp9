using System;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Sorting *****");

            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);
            Console.WriteLine("Unordered set of cars:");
            foreach (var car in myAutos)
            {
                Console.WriteLine($"{car.CarID} {car.PetName}");
            }
            
            //Array.Sort(myAutos);
            //Array.Sort(myAutos, new PetNameComparer());
            Array.Sort(myAutos, Car.SortByPetName);
            Console.WriteLine();

            Console.WriteLine("Ordered set of cars:");
            foreach (var car in myAutos)
            {
                Console.WriteLine($"{car.CarID} {car.PetName}");
            }
            
            
            Console.ReadLine();
        }
    }
}