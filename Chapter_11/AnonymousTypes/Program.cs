using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Anonymous types *****");
            
            //BuildAnonymousType("Honda", "Grey", 60);
            
            //var car = new { Make = "Honda", Color = "Red", Speed = 55 };
            
            //ReflectOverAnonymousType(car);
            
            EqualityTest();

            Console.ReadLine();
        }

        static void BuildAnonymousType(string make, string color, int currentSpeed)
        {
            var car = new { Make = make, Color = color, Speed = currentSpeed };

            Console.WriteLine($"{car.Color} {car.Make} is going {car.Speed} MPH");

            Console.WriteLine($"car.ToString() = {car}");
        }
        
        static void ReflectOverAnonymousType(object obj)
        {
            Console.WriteLine("obj is an instance of: {0}",
                obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}",
                obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}",
                obj.GetHashCode());
            Console.WriteLine();
        }

        static void EqualityTest()
        {
            // Make 2 anonymous classes with identical name/value pairs.
            var firstCar = new { Color = "Bright Pink", Make = "Saab",
                CurrentSpeed = 55 };
            var secondCar = new { Color = "Bright Pink", Make = "Saab",
                CurrentSpeed = 55 };

            if (firstCar.Equals(secondCar))
            {
                Console.WriteLine("Same anonymous object (Equals)!");
            }
            else
            {
                Console.WriteLine("Not the same anonymous object");
            }

            if (firstCar == secondCar)
            {
                Console.WriteLine("Same anonymous object (==)");
            }
            else
            {
                Console.WriteLine("Not the same anonymous object");
            }

            if (firstCar.GetType().Name == secondCar.GetType().Name)
            {
                Console.WriteLine("Both the same type");
            }
            else
            {
                Console.WriteLine("Different types");
            }
            ReflectOverAnonymousType(firstCar);
            ReflectOverAnonymousType(secondCar);
            
        }
    }
}