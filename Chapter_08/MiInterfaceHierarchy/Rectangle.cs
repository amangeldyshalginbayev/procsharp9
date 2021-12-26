using System;

namespace MiInterfaceHierarchy
{
    public class Rectangle : IShape
    {
        public int GetNumberOfSides() => 4;
        // public void Draw()
        // {
        //     Console.WriteLine("Drawing Rectangle...");
        // }

        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing Rectangle to screen...");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Drawing Rectangle to printer...");
        }

        public void Print()
        {
            Console.WriteLine("Printing Rectangle...");
        }
    }
}