using System;

namespace FunWithStructures
{
    public struct DisposableRefStruct
    {
        public int X;
        public readonly int Y;
        
        
        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
        
        // A custom constructor.
        public DisposableRefStruct(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
            Console.WriteLine("Created!");
        }
        
        public void Dispose()
        {
            //clean up any resources here
            Console.WriteLine("Disposed!");
        }
    }
}