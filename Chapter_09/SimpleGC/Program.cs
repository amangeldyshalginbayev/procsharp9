using System;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("***** GC Basics *****");
            //
            // Car refToMyCar = new Car(50, "Zippy");
            //
            // Console.WriteLine(refToMyCar);
            //
            // Console.ReadLine();

            Console.WriteLine("***** Fun with System.GC *****");

            Console.WriteLine($"Estimated number of bytes on heap: {GC.GetTotalMemory(false)}");
            Console.WriteLine($"This OS has {GC.MaxGeneration + 1} generations");

            Car refToMyCar = new Car(100, "Zippy");
            Console.WriteLine(refToMyCar.ToString());
            Console.WriteLine($"Generation of refToMyCar is: {GC.GetGeneration(refToMyCar)}");

            object[] tonsOfObjects = new object[50000];
            for (int i = 0; i < 50000; i++)
            {
                tonsOfObjects[i] = new object();
            }
            
            // Collect only generation 0 objects
            Console.WriteLine("Force Garbage Collection");
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            Console.WriteLine($"Generation of refToMyCar is: {GC.GetGeneration(refToMyCar)}");

            // See if tonsOfObjects[9000] is still alive.
            if (tonsOfObjects[9000] != null)
            {
                Console.WriteLine($"Generation of tonsOfObjects[9000] is: {GC.GetGeneration(tonsOfObjects[9000])}");
            }
            else
            {
                Console.WriteLine("tonsOfObjects[9000] is no longer alive.");
            }

            Console.WriteLine($"Gen 0 has been swept {GC.CollectionCount(0)} times");
            Console.WriteLine($"Gen 1 has been swept {GC.CollectionCount(1)} times");
            Console.WriteLine($"Gen 2 has been swept {GC.CollectionCount(2)} times");

            Console.ReadLine();
        }
    }
}