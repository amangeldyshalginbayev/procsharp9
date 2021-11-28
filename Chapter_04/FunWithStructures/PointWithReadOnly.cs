using System;

namespace FunWithStructures
{
    public struct PointWithReadOnly
    {
        public int X;
        public readonly int Y;
        public readonly string Name;

        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
        }

        public PointWithReadOnly(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}