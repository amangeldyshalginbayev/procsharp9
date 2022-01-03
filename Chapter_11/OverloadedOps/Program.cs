using System;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Overloaded Operators *****\n");
            //OverLoadedOpWithPoint();
            //OverLoadedOpWithDifferentParams();
            //OverLoadedForFree();
            OverLoadIncrementDecrementOp();
        }

        static void OverLoadedOpWithPoint()
        {
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Console.WriteLine("ptOne = {0}", ptOne);
            Console.WriteLine("ptTwo = {0}", ptTwo);

            Console.WriteLine("ptOne + ptTwo: {0} ", ptOne + ptTwo);

            Console.WriteLine("ptOne - ptTwo: {0} ", ptOne - ptTwo);
            Console.ReadLine();
        }

        static void OverLoadedOpWithDifferentParams()
        {
            Point ptOne = new Point(90, 90);
            // Prints [110, 110].
            Point biggerPoint = ptOne + 10;
            Console.WriteLine("ptOne + 10 = {0}", biggerPoint);
            // Prints [120, 120].
            Console.WriteLine("10 + biggerPoint = {0}", 10 + biggerPoint);
            Console.WriteLine();
        }

        static void OverLoadedForFree()
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 2);

            p1 += p2;
            Console.WriteLine($"p1 += p2 : {p1}");
        }

        static void OverLoadIncrementDecrementOp()
        {
            Point p = new Point(9, 9);
            Console.WriteLine($"p++ : {++p}");

            Console.WriteLine($"p-- : {--p}");
        }
    }
}