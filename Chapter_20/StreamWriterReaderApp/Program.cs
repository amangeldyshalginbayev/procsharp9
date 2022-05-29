using System;
using System.IO;

namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteToTextFile();
            ReadFromTextFile();
        }

        private static void WriteToTextFile()
        {
            Console.WriteLine("***** Fun with StreamWriter and StreamReader *****\n");
            
            var fileName = @"/Users/aman/Desktop/files/repositories/procsharp9/Chapter_20/reminders.txt";

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("Remind me about task 1");
                sw.WriteLine("Remind me about task 2");
                sw.WriteLine("Remind me about task 3");
                
                sw.WriteLine("Dont forget these numbers:");
                for (int i = 0; i < 10; i++)
                {
                    sw.Write($"{i} ");
                }
                
                // insert new line
                sw.Write(sw.NewLine);
            }

            Console.WriteLine("Created file: reminders.txt");
        }

        private static void ReadFromTextFile()
        {
            Console.WriteLine("Here are your thoughts: ");
            var fileName = @"/Users/aman/Desktop/files/repositories/procsharp9/Chapter_20/reminders.txt";

            using (StreamReader sr = File.OpenText(fileName))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }

            Console.ReadLine();
        }
    }
}