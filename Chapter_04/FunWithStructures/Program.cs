using System;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            // Point myPoint;
            // myPoint.X = 349;
            // myPoint.Y = 76;
            // myPoint.Display();
            //
            // myPoint.Increment();
            // myPoint.Display();

            // Point p1;
            // p1.X = 10;
            // p1.Y = 10;
            // p1.Display();

            // Point p2 = new Point();
            // p2.Display();
            //
            // Point p3 = new Point(50, 60);
            // p3.Display();

            // ReadOnlyPoint p4 = new ReadOnlyPoint(10, 20);
            // p4.Display();

            // PointWithReadOnly p5 = new PointWithReadOnly(50,60, "Point w/RO");
            // p5.Display();
            // p5.X = 500;
            // p5.Display();

            //p5.Y = 700; compiler error

            var s = new DisposableRefStruct(50, 60);
            s.Display();
            s.Dispose();
            
            Console.ReadLine();
        }
    }
}