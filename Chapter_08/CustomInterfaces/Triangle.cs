using System;

namespace CustomInterfaces
{
    public class Triangle : Shape, IPointy
    {
        public Triangle()
        {
            Console.WriteLine("Triangle() called.");
        }

        public Triangle(string petName) : base(petName)
        {
            Console.WriteLine("Triangle(string petName) : base(petName) called.");
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Triangle.");
        }

        public byte GetNumberOfPoints() => 3;

        public byte Points => 3;
    }
}