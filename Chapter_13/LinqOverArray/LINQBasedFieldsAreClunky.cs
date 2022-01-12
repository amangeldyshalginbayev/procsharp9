using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverArray
{
    public class LINQBasedFieldsAreClunky
    {
        private static string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

        private IEnumerable<string> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;

        public void PrintGames()
        {
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
        }
    }
}