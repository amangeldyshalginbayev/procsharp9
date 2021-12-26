using System;

namespace MiInterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with multiple interface hierarchy! *****");

            Rectangle rectangle = new Rectangle();
            
            rectangle.Print();
            Console.WriteLine(rectangle.GetNumberOfSides());

            Console.WriteLine("Drawing rectangle as IDrawable:");
            ((IDrawable)rectangle).Draw();

            Console.WriteLine("Drawing rectangle as IPrintable:");
            ((IPrintable)rectangle).Draw();
        }
    }
}