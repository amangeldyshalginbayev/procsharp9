using System;

namespace FunWithValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ValueTypeAssignment();
            //ReferenceTypeAssignment();
            ValueTypeContainingRefType();
            
        }
        
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;
            
            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10,10);
            PointRef p2 = p1;
            
            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            Console.WriteLine("-> Assigning r1 to r2");
            Rectangle r2 = r1;

            Console.WriteLine("-> Changing values of r2");
            r2.RectInfo.InfoString = "This is new info!";
            r2.RectBottom = 4444;
            
            r1.Display();
            r2.Display();
        }
    }
}