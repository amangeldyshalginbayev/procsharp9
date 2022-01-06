using System;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with events *****\n");

            Car c1 = new Car("SlugBug", 100, 10);

            // Register event handlers
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;

            Car.CarEngineHandler d = CarExploded;
            c1.Exploded += d;

            Console.WriteLine("Speeding up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            // Remove CarExploded method from invocation list.
            c1.Exploded -= d;

            Console.WriteLine("Speeding up again");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadLine();
        }

        static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine("CarAboutToBlow() called.");
            if (sender is Car c)
            {
                Console.WriteLine($"Critical message from {c.Name}: {e.msg}");
            }
        }

        static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine("CarIsAlmostDoomed() called.");
            Console.WriteLine($"{sender} says: {e.msg}");
        }

        static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine("CarExploded() called.");
            Console.WriteLine($"{sender} says: {e.msg}");
        }
    }
}