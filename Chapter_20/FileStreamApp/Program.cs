using System;
using System.IO;
using System.Text;

namespace FileStreamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStreamExample();
        }

        private static void FileStreamExample()
        {
            Console.WriteLine("***** Fun with FileStream *****\n");

            var fileName =  @"/Users/aman/Desktop/files/repositories/procsharp9/Chapter_20/filestream_example.dat";

            using (FileStream fs = File.Open(fileName,FileMode.Create))
            {
                string msg = "Hello from FileStreamExample() method!!!";
                byte[] msgByteArray = Encoding.Default.GetBytes(msg);
                
                fs.Write(msgByteArray,0,msgByteArray.Length);

                Console.WriteLine("Check created file content now >>>");
                fs.Flush(); // this immediately writes to the file content form stream
                Console.ReadLine();
                

                fs.Position = 0;

                Console.WriteLine("Your message as an array of bytes:");
                
                byte[] bytesFromFile = new byte[msgByteArray.Length];

                for (int i = 0; i < msgByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fs.ReadByte();
                    Console.Write($"[{bytesFromFile[i]}] ");
                }
                
                Console.Write("\nDecoded message:");
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }
        }
    }
}