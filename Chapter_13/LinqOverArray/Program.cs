using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with LINQ to objects *****\n");

            //QueryOverStrings();
            //QueryOverStringsWithExtensionMethods();
            //QueryOverInts();
            //QueryOverIntsUpdated();
            ImmediateExecution();
            
            Console.ReadLine();
        }

        static void QueryOverStrings()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            IEnumerable<string> subset =
                from g in currentVideoGames
                where g.Contains(" ")
                orderby g
                select g;

            ReflectOverQueryResults(subset);

            foreach (var s in subset)
            {
                Console.WriteLine($"Item: {s}");
            }
        }

        static void QueryOverStringsWithExtensionMethods()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            IEnumerable<string> subset = currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);

            ReflectOverQueryResults(subset, "Extension Methods.");

            foreach (var s in subset)
            {
                Console.WriteLine($"Item: {s}");
            }
        }

        static void QueryOverStringsLongHand()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            string[] gamesWithSpaces = new string[5];

            for (int i = 0; i < currentVideoGames.Length; i++)
            {
                if (currentVideoGames[i].Contains(" "))
                {
                    gamesWithSpaces[i] = currentVideoGames[i];
                }
            }

            Array.Sort(gamesWithSpaces);

            foreach (var s in gamesWithSpaces)
            {
                if (s != null)
                {
                    Console.WriteLine($"Item: {s}");
                }
            }

            Console.WriteLine();
        }

        static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"Info about your query using {queryType}");
            Console.WriteLine($"resultSet is of type: {resultSet.GetType().Name}");
            Console.WriteLine($"resultSet location: {resultSet.GetType().Assembly.GetName().Name}");
        }

        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var subset = from i in numbers where i < 10 select i;

            foreach (var i in subset)
            {
                Console.WriteLine($"Item: {i}");
            }

            ReflectOverQueryResults(subset);
        }

        static void QueryOverIntsUpdated()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            var subset = from i in numbers where i < 10 select i;

            foreach (var i in subset)
            {
                Console.WriteLine($"{i} < 10");
            }

            Console.WriteLine("--------------");

            numbers[0] = 4;
            foreach (var j in subset)
            {
                Console.WriteLine($"{j} < 10");
            }

            Console.WriteLine();
            ReflectOverQueryResults(subset);
        }
        
        static void ImmediateExecution()
        {
            Console.WriteLine();
            Console.WriteLine("Immediate Execution");
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            
            int number = (from i in numbers select i).First();
            Console.WriteLine("First is {0}", number);
            
            number = (from i in numbers orderby i select i).First();
            Console.WriteLine("First is {0}", number);
            
            number = (from i in numbers where i > 30 select i).Single();
            Console.WriteLine("Single is {0}", number);
            try {
                number = (from i in numbers where i > 10 select i).Single();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: {0}", ex.Message);
            }
            // Get data RIGHT NOW as int[].
            int[] subsetAsIntArray =
                (from i in numbers where i < 10 select i).ToArray<int>();
            // Get data RIGHT NOW as List<int>.
            List<int> subsetAsListOfInts =
                (from i in numbers where i < 10 select i).ToList<int>();
        }
    }
}