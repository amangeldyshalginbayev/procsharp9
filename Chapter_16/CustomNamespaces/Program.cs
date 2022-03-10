using System;
//using My3DShapes;
// using MyShapes;
// using My3DShapes;
//using My3DShapes;
using CustomNamespaces.MyShapes;
using MyShapes;
using The3DHexagon = CustomNamespaces.My3DShapes.Hexagon;


namespace CustomNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            My3DShapes.Hexagon h = new My3DShapes.Hexagon();
            
            Console.WriteLine(h.GetType().FullName);
            
            MyShapes.Circle c = new MyShapes.Circle();

            Square s = new Square();

            My3DShapes.Square s1 = new My3DShapes.Square();

            MyShapes.Circle c1 = new MyShapes.Circle();

            The3DHexagon threeDHexagon = new The3DHexagon();
        }
    }
}