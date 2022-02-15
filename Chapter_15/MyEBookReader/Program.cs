using System;
using System.Linq;
using System.Net;
using System.Text;

namespace MyEBookReader
{
    class Program
    {
        private static string _theEbook = "";

        static void Main(string[] args)
        {
            Console.WriteLine("My Ebook Reader");
            GetBook();
            Console.WriteLine("Downloading book...");
            Console.ReadLine();
        }


        static void GetBook()
        {
            WebClient wc = new WebClient();
            wc.DownloadStringCompleted += (s, eArgs) =>
            {
                _theEbook = eArgs.Result;
                Console.WriteLine("Download complete.");
                GetStats();
            };

            wc.DownloadStringAsync(new Uri("https://www.gutenberg.org/files/98/98-0.txt"));
        }

        static void GetStats()
        {
            string[] words = _theEbook.Split(new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/' },
                StringSplitOptions.RemoveEmptyEntries);

            string[] tenMostCommon = FindTenMostCommon(words);

            string longestWord = FindLongestWord(words);

            StringBuilder bookStats = new StringBuilder("Ten Most Common Words are:\n");
            foreach (var s in tenMostCommon)
            {
                bookStats.AppendLine(s);
            }

            bookStats.AppendFormat($"Longest word is: {longestWord}");
            bookStats.AppendLine();
            Console.WriteLine("{0}:\n" + bookStats.ToString(), "Book info");
        }

        static string[] FindTenMostCommon(string[] words)
        {
            var frequencyOrder = from word in words
                where word.Length > 6
                group word by word
                into g
                orderby g.Count() descending
                select g.Key;

            string[] commonWords = (frequencyOrder.Take(10)).ToArray();
            return commonWords;
        }

        static string FindLongestWord(string[] words)
        {
            return (from w in words orderby w.Length descending select w).FirstOrDefault();
        }
    }
}