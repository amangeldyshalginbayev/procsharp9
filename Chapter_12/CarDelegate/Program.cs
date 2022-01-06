using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Delegates as event enablers **");
            // Car c1 = new Car("SlugBug", 100, 10);
            //
            // c1.CheckEventHandler();
            // c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            // c1.CheckEventHandler();
            // c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));
            //
            // Console.WriteLine("Speeding up!");
            // for (int i = 0; i < 6; i++)
            // {
            //     c1.Accelerate(20);
            // }

            // Car c1 = new Car("SlugBug", 100, 10);
            // c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            //
            // Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            // c1.RegisterWithCarEngine(handler2);
            //
            // // Speed up (this will trigger the events).
            // Console.WriteLine("***** Speeding up *****");
            // for (int i = 0; i < 6; i++)
            // {
            //     c1.Accelerate(20);
            // }
            //
            // c1.UnRegisterWithCarEngine(handler2);
            //
            // // We won't see the "uppercase" message anymore!
            // Console.WriteLine("***** Speeding up *****");
            // for (int i = 0; i < 6; i++)
            // {
            //     c1.Accelerate(20);
            // }
            
            Console.WriteLine("***** Method Group Conversion *****\n");
            Car c2 = new Car();
            
            c2.RegisterWithCarEngine(OnCarEngineEvent);
            
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c2.Accelerate(20);
            }

            c2.UnRegisterWithCarEngine(OnCarEngineEvent);

            Console.WriteLine("NO MORE NOTIFICATIONS");
            // No more notifications!
            for (int i = 0; i < 6; i++)
            {
                c2.Accelerate(20);
            }


            Console.ReadLine();
        }

        static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n*** Message from Car object ***");
            Console.WriteLine($"=> {msg}");
            Console.WriteLine("****************************\n");
        }

        static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine($"=> {msg.ToUpper()}");
        }
    }
}