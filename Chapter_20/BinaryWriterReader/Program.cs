using System;
using System.IO;

namespace BinaryWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriterReader();
        }

        private static void BinaryWriterReader()
        {
            FileInfo fileInfo = new FileInfo( @"/Users/aman/Desktop/files/repositories/procsharp9/Chapter_20/binfile.txt");

            using (BinaryWriter bw = new BinaryWriter(fileInfo.OpenWrite()))
            {
                Console.WriteLine($"Base stream is: {bw.BaseStream}");

                double dValue = 123.456;
                int iValue = 123;
                string sValue = "ABC";
                bw.Write(dValue);
                bw.Write(iValue);
                bw.Write(sValue);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}