using System;

namespace FunWithStructures
{
    public readonly struct ReadOnlyPoint
    {
        public int X { get;  }
        public int Y { get; }
        
        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public ReadOnlyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}