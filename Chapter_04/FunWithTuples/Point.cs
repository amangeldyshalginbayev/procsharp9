namespace FunWithTuples
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public (int XPos, int YPos) Deconstruct() => (X, Y);
        
    }
}