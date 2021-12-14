using System;

namespace RecordInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Record type inheritance!");

            // Car c = new Car("Honda", "Pilot", "Blue");
            // MiniVan m = new MiniVan("Honda", "Pilot", "Blue", 10);
            // Console.WriteLine($"Checking MiniVan is-a Car:{m is Car}");

            // PositionalCar pc = new PositionalCar("Honda", "Pilot", "Blue");
            // PositionalMinivan pm = new PositionalMinivan("Honda", "Pilot", "Blue", 10);
            // Console.WriteLine($"Checking PositionalMiniVan is-a PositionalCar:{pm is PositionalCar}");

            MotorCycle mc = new MotorCycle("Harley", "Lowrider");
            Scooter sc = new Scooter("Harley", "Lowrider");
            Console.WriteLine($"MotorCycle and Scooter are equal: {Equals(mc,sc)}");
        }
    }
}