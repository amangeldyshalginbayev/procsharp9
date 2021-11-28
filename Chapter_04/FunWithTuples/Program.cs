using System;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // var values = ("a", 5, "c");
            //
            // Console.WriteLine($"First item: {values.Item1}");
            // Console.WriteLine($"Second item: {values.Item2}");
            // Console.WriteLine($"Third item: {values.Item3}");
            //
            // (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
            // var valuesWithNames2 = (FirstLetter : "a", TheNumber : 5, SecondLetter : "c");
            //
            // Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            // Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            // Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
            //
            // Console.WriteLine($"First item: {valuesWithNames.Item1}");
            // Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            // Console.WriteLine($"Third item: {valuesWithNames.Item3}");

            // var samples = FillTheseValues();
            // Console.WriteLine($"Int is: {samples.a}");
            // Console.WriteLine($"String is: {samples.b}");
            // Console.WriteLine($"Boolean is: {samples.c}");

            Point p = new Point(7, 5);
            var pointValues = p.Deconstruct();
            Console.WriteLine($"X is: {pointValues.XPos}");
            Console.WriteLine($"Y is: {pointValues.YPos}");
            
            
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string.", true);
        }

        static string GetQuadrant1(Point p)
        {
            return p.Deconstruct() switch
            {
                (0, 0) => "Origin",
                var (x, y) when x > 0 && y > 0 => "One",
                var (x, y) when x < 0 && y > 0 => "Two",
                var (x, y) when x < 0 && y < 0 => "Three",
                var (x, y) when x > 0 && y < 0 => "Four",
                var (_, _) => "Border"
            };
        }
    }
}