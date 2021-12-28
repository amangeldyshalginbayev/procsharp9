using System;
using System.IO;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Dispose *****");

            //MyResourceWrapper rw = new MyResourceWrapper();
            //rw.Dispose();
            // if (rw is IDisposable)
            // {
            //     rw.Dispose();
            // }
            
            //UsePatternWithUsing();
            UsingDeclaration();

            Console.ReadLine();
        }
        
        static void DisposeFileStream()
        {
            FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);
            // Confusing, to say the least!
            // These method calls do the same thing!
            fs.Close();
            fs.Dispose();
        }

        static void UsePattern()
        {
            MyResourceWrapper rw = new MyResourceWrapper();

            try
            {
                Console.WriteLine("Using members of [rw].");
            }
            finally
            {
                // always call Dispose() despite errors!
                rw.Dispose();
            }
        }

        static void UsePatternWithUsing()
        {
            // Dispose() called automatically when using scope ends
            using (MyResourceWrapper rw = new MyResourceWrapper())
            {
                Console.WriteLine("Using rw object here!");
            }
        }

        static void UsePatternWithUsingMultiple()
        {
            // Use a comma-delimited list to declare multiple objects to dispose.
            using(MyResourceWrapper rw = new MyResourceWrapper(), rw2 = new MyResourceWrapper())
            {
                // Use rw and rw2 objects.
            }
        }

        private static void UsingDeclaration()
        {
            //This variable will be in scope until the end of the method
            using var rw = new MyResourceWrapper();
            //Use rw object here
            Console.WriteLine("About to dispose.");
            //Variable is disposed at this point.
        }

    }
}