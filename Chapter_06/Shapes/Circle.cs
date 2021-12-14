using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle()
        {
            Console.WriteLine("Circle() called.");
        }

        public Circle(string petName = "NoName") : base(petName)
        {
            Console.WriteLine("Circle(string petName = 'NoName') : base(petName) called.");
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName ?? "No Name"} the Circle.");
        }
    }
}