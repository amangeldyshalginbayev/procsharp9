using System;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Anonymous methods *****");
            int aboutToBlowCounter = 0;

            Car c1 = new Car("SlugBug", 100, 10);
            
            // Register event handlers as anonymous methods
            c1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eek! Going too fast!");
            };

            c1.AboutToBlow += delegate(object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine($"Message from Car: {e.msg}");
            };

            c1.Exploded += delegate(object sender, CarEventArgs e)
            {
                Console.WriteLine($"Fatal message from Car: {e.msg}");
            };

            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            
            Console.WriteLine($"About to blow event was fired {aboutToBlowCounter} times.");
            
            Func<int,int,int> constantDelegate = delegate(int _, int _) { return 42; };
            Console.WriteLine($"constantDelegate(1,2) = {constantDelegate(1,2)}");
            Console.ReadLine();
        }
    }
}