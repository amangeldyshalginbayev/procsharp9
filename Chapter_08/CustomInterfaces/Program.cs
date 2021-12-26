using System;

namespace CustomInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");
            //CloneableExample();
            // Hexagon hex = new Hexagon();
            // Console.WriteLine($"Points: {hex.Points}");

            // Circle c = new Circle("Lisa");
            // IPointy itfPt = null;
            // try
            // {
            //     itfPt = (IPointy)c;
            //     Console.WriteLine(itfPt.Points);
            // }
            // catch (InvalidCastException e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            // Hexagon hex2 = new Hexagon("Peter Pan");
            // IPointy itfPt2 = hex2 as IPointy;
            // if (itfPt2 != null)
            // {
            //     Console.WriteLine($"Points: {itfPt2.Points}");
            // }
            // else
            // {
            //     Console.WriteLine("OOPS! Not pointy...");
            // }

            // if (hex2 is IPointy itfPt3)
            // {
            //     Console.WriteLine($"Points: {itfPt3.Points}");
            // }
            // else
            // {
            //     Console.WriteLine("OOPS! Not pointy...");
            // }

            // var sq = new Square("Boxy") {NumberOfSides = 4, SideLength = 4};
            // sq.Draw();
            // Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} sides of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");
            //
            // Console.WriteLine("Test line");
            //
            // Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
            // IRegularPointy.ExampleProperty = "Updated";
            // Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");

            //Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            // foreach (var shape in myShapes)
            // {
            //     if (shape is IDraw3D threeDshape)
            //     {
            //         DrawIn3D(threeDshape);
            //     }
            //     
            // }
            // IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            // Console.WriteLine($"The item has {firstPointyItem?.Points} points.");

            IPointy[] myPointyObjects = { new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork() };

            foreach (var pointy in myPointyObjects)
            {
                Console.WriteLine($"Object has {pointy.Points} points.");
            }

            Console.ReadLine();
        }

        static void CloneableExample()
        {
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());

            CloneMe(myStr);
            CloneMe(unixOS);

            static void CloneMe(ICloneable c)
            {
                object theClone = c.Clone();
                Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
            }
        }

        static void DrawIn3D(IDraw3D idrawIn3D)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type.");
            idrawIn3D.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (var shape in shapes)
            {
                if (shape is IPointy pointy)
                {
                    return pointy;
                }
            }

            return null;
        }
    }
}