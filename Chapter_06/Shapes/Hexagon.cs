using System;

namespace Shapes
{
    public class Hexagon : Shape
    {
        public Hexagon()
        {
            Console.WriteLine("Hexagon() called.");
        }

        public Hexagon(string petName = "NoName") : base(petName)
        {
            Console.WriteLine("Hexagon(string petName = 'NoName') : base(petName) called.");
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName ?? "No Name"} the Hexagon.");
        }
    }
}