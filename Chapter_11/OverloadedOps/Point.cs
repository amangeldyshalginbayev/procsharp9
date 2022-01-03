using System;

namespace OverloadedOps
{
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int CompareTo(Point other)
        {
            if (X == other.X && Y == other.Y)
            {
                return 1;
            }

            if (X < other.X && Y < other.Y)
            {
                return -1;
            }

            return 0;
        }

        public static bool operator <(Point p1, Point p2) => p1.CompareTo(p2) < 0;

        public static bool operator >(Point p1, Point p2) => p1.CompareTo(p2) > 0;
        
        public static bool operator <=(Point p1, Point p2) => p1.CompareTo(p2) <= 0;
        
        public static bool operator >=(Point p1, Point p2) => p1.CompareTo(p2) >= 0;


        public override string ToString() => $"[{X}, {Y}]";

        public static Point operator +(Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);

        public static Point operator -(Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);

        public static Point operator +(Point p, int change) => new Point(p.X + change, p.Y + change);
        
        public static Point operator +(int change, Point p) => new Point(p.X + change, p.Y + change);

        public static Point operator ++(Point p) => new Point(p.X + 1, p.Y + 1);

        public static Point operator --(Point p) => new Point(p.X - 1, p.Y - 1);

        public override bool Equals(object obj) => obj.ToString() == ToString();

        public override int GetHashCode() => ToString().GetHashCode();

        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);

        public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);
    }
}