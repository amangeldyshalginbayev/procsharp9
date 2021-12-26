using System;

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point()
        {
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public Point(int x, int y, string petName)
        {
            X = x;
            Y = y;
            desc.PetName = petName;
        }

        public override string ToString() => $"X = {X}; Y = {Y}; Name = {desc.PetName}; ID = {desc.PointID}";

        //public object Clone() => new Point(X,Y);

        //public object Clone() => MemberwiseClone();

        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();

            PointDescription currentDesc = new PointDescription
            {
                PetName = this.desc.PetName
            };
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}