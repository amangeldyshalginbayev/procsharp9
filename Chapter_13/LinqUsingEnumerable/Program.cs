using System;
using System.Linq;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueryStringsWithOperators();
            //QueryStringsWithEnumerableAndLambdas();
            //QueryStringsWithEnumerableAndLambdas2();
            //QueryStringsWithAnonymousMethods();
            VeryComplexQueryExpression.QueryStringsWithRawDelegates();
        }

        static void QueryStringsWithOperators()
        {
            Console.WriteLine("***** Using Query Operators *****");
            
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            var subset = from game in currentVideoGames where game.Contains(" ") orderby game select game;

            foreach (var s in subset)
            {
                Console.WriteLine($"Item: {s}");
            }
        }

        static void QueryStringsWithEnumerableAndLambdas()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
            
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            var subset = currentVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);

            foreach (var game in subset)
            {
                Console.WriteLine($"Item: {game}");
            }

            Console.WriteLine();
        }

        static void QueryStringsWithEnumerableAndLambdas2()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
            
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            var gamesWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
            var orderedGames = gamesWithSpaces.OrderBy(game => game);
            var subset = orderedGames.Select(game => game);

            foreach (var game in subset)
            {
                Console.WriteLine($"Item: {game}");
            }

            Console.WriteLine();
        }

        static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("***** Using Anonymous Methods *****");
            
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};
            
            // Build the necessary Func<> delegates using anonymous methods.
            Func<string, bool> searchFilter = delegate(string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess = delegate(string s) { return s; };

            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
            
            foreach (var game in subset)
            {
                Console.WriteLine($"Item: {game}");
            }

            Console.WriteLine();
        }
    }
}