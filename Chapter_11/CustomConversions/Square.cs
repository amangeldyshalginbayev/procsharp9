using System;

namespace CustomConversions
{
    public struct Square
    {
        public int Length { get; set; }

        public Square(int length) : this()
        {
            Length = length;
        }
        
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public override string ToString() => $"[Length = {Length}]";

        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square { Length = r.Height };
            return s;
        }

        public static explicit operator Square(int sideLength)
        {
            Square newSquare = new Square { Length = sideLength };
            return newSquare;
        }

        public static explicit operator int(Square s) => s.Length;
    }
}