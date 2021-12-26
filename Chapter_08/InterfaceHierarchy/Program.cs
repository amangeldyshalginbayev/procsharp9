using System;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Interface Hierarchy *****\n");

            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10,10,100,150);
            myBitmap.DrawUpsideDown();

            if (myBitmap is IAdvancedDraw iAdvDraw)
            {
                iAdvDraw.DrawUpsideDown();
                Console.WriteLine($"Time to draw: {iAdvDraw.TimeToDraw()}");
            }
            
            // This does not compile, as TimeToDraw() is defined in interface, not in class itself! need to cast to interface type the object first
            //myBitmap.TimeToDraw();

            Console.WriteLine("Calling Implemented TimeToDraw()");
            Console.WriteLine($"Time to draw: {myBitmap.TimeToDraw()}");
            Console.WriteLine($"Time to draw: {((IDrawable)myBitmap).TimeToDraw()}");
            Console.WriteLine($"Time to draw: {((IAdvancedDraw)myBitmap).TimeToDraw()}");

            Console.ReadLine();
        }
    }
}