using System;
using System.IO;
using System.Text;

namespace StringReaderWriterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriterReaderExample();
        }

        private static void WriterReaderExample()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.WriteLine("Dont forget mothers Day this year");

                Console.WriteLine($"Content of string writer: {sw}");
                
                // Get the internal StringBuilder object
                StringBuilder sb = sw.GetStringBuilder();
                sb.Insert(0, "Hey!! ");
                Console.WriteLine($"-> {sb.ToString()}");
                sb.Remove(0, "Hey!! ".Length);
                Console.WriteLine($"-> {sb.ToString()}");
            }

            Console.ReadLine();
        }
    }
}