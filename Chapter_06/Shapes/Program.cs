using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            // Hexagon hex = new Hexagon("Beth");
            // hex.Draw();
            // Circle cir = new Circle("Cindy");
            // cir.Draw();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"),new Circle("Beth"), new Hexagon("Linda")};

            foreach (var s in myShapes)
            {
                s.Draw();
            }
            
            Console.ReadLine();
        }
        
    }
}