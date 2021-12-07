using System;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point finalPoint = new Point { X = 30, Y = 30 };
            // finalPoint.DisplayStats();

            //Make readonly point after construction
            // PointReadOnlyAfterCreation firstReadonlyPoint = new PointReadOnlyAfterCreation(20, 20);
            // firstReadonlyPoint.DisplayStats();
            // Or make a Point using object init syntax.
            // PointReadOnlyAfterCreation secondReadonlyPoint = new PointReadOnlyAfterCreation
            // {
            //     X = 30,
            //     Y = 30
            // };
            // secondReadonlyPoint.DisplayStats();

            //firstReadonlyPoint.X = 10;
            
            // Point goldPoint = new Point(PointColorEnum.Gold){ X = 90, Y = 20 };
            // goldPoint.DisplayStats();

            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point {X = 10, Y = 10},
                BottomRight = new Point {X = 200, Y = 200}
            };
            
            Console.ReadLine();
        }
    }
}