using System;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generic structures *****");

            // Point<int> p = new Point<int>(10, 10);
            //
            // Console.WriteLine($"p.ToString = {p}");
            // p.ResetPoint();
            // Console.WriteLine($"p.ToString = {p}");
            // Console.WriteLine();
            //
            //
            // Point<double> p2 = new Point<double>(5.4, 3.3);
            // Console.WriteLine("p2.ToString()={0}", p2.ToString());
            // p2.ResetPoint();
            // Console.WriteLine("p2.ToString()={0}", p2.ToString());
            // Console.WriteLine();
            //
            // Point<string> p3 = new Point<string>("i", "3i");
            // Console.WriteLine("p3.ToString()={0}", p3.ToString());
            // p3.ResetPoint();
            // Console.WriteLine("p3.ToString()={0}", p3.ToString());

            Point<string> p4 = default;
            Point<int> p5 = default;
            PatternMatching(p4);
            PatternMatching(p5);
            
            Console.ReadLine();
        }

        static void PatternMatching<T>(Point<T> p)
        {
            switch (p)
            {
                case Point<string> pString:
                    Console.WriteLine("Point is based on string.");
                    return;
                case Point<int> pInt:
                    Console.WriteLine("Point is based on int.");
                    return;
            }
        }
    }
}