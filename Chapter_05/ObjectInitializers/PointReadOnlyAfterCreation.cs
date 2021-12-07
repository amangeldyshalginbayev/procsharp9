using System;

namespace ObjectInitializers
{
    public class PointReadOnlyAfterCreation
    {
        public int X { get; init; }
        public int Y { get; init; }

        public void DisplayStats()
        {
            Console.WriteLine("InitOnlySetter: [{0}, {1}]", X, Y);
        }

        public PointReadOnlyAfterCreation(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }

        public PointReadOnlyAfterCreation()
        {
        }
    }
}