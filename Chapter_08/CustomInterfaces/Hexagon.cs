using System;

namespace CustomInterfaces
{
    public class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon()
        {
            Console.WriteLine("Hexagon() called.");
        }

        public Hexagon(string petName) : base(petName)
        {
            Console.WriteLine("Hexagon(string petName = 'NoName') : base(petName) called.");
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon.");
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D!");
        }

        public byte GetNumberOfPoints() => 6;

        public byte Points => 6;
        
    }
}