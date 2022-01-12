using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ return values *****\n");

            //var subset = GetStringSubset();
            var subset = GetStringSubsetAsArray();

            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = {"Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple"};

            var theRedColors = from c in colors where c.Contains("Red") select c;

            return theRedColors;
        }

        static string[] GetStringSubsetAsArray()
        {
            string[] colors = {"Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple"};

            var theRedColors = from c in colors where c.Contains("Red") select c;

            return theRedColors.ToArray();
        }
    }
}