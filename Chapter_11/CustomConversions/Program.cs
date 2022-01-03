using System;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");
            //ExplicitConvertRectToSquare();
            //ImplicitCastExample();

            Console.ReadLine();
        }

        static void ExplicitConvertRectToSquare()
        {
            // Make a Rectangle.
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r);
            r.Draw();
            Console.WriteLine();
            // Convert r into a Square,
            // based on the height of the Rectangle.
            Square s = (Square)r;
            Console.WriteLine(s);
            s.Draw();
        }

        static void ImplicitCastExample()
        {
            Square s = new Square { Length = 7 };
            Rectangle r = s;
            Console.WriteLine($"Rectangle = {r}");
            
            // Explicit cast syntax also work!
            Square s2 = new Square { Length = 10 };
            Rectangle r2 = (Rectangle)s2;
            Console.WriteLine($"Rectangle = {r2}");
        }
    }
}