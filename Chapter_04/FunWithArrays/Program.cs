using System;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleArrays();
            //ArrayInitialization();
            //DeclareImplicitArrays();
            //ArrayOfObjects();
            //RectMultidimensionalArray();
            //JaggedMultidimensionalArray();
            //SystemArrayFunctionality();
            UsingIndexAndRange();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");

            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (var i in myInts)
            {
                Console.WriteLine(i);
            }

            //string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a: {0}", a.ToString());

            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b: {0} ", b.ToString());

            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c: {0}", c.ToString());
            Console.WriteLine();

            var d = new[]
            {
                1.0000000000000000000000000000000000000000000000000000000000000001f, 1.0000000000000000009
            }; // d is System.Double[]
            Console.WriteLine("d: {0}", d.ToString());
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects:");

            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                Console.WriteLine($"Type: {obj.GetType()}, Value: {obj}");
            }

            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");

            int[,] myMatrix;
            myMatrix = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");

            int[][] myJagArray = new int[5][];

            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            // Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhus", "Sisters of Mercy" };
            
            // Print out names in declared order
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");
            
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            
            Console.WriteLine("\n");

            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands,1,2);
            
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            
            Console.WriteLine("");
        }

        static void UsingIndexAndRange()
        {
            Console.WriteLine("=> Working with Indexes and Ranges.");
            // Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhus", "Sisters of Mercy" };

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Index idx = i;
                Console.WriteLine(gothicBands[idx] + ", ");
            }

            Console.WriteLine("-> Print elements from end.");

            for (int i = 1; i < gothicBands.Length + 1; i++)
            {
                Index idx = ^i;
                Console.Write($"Index: {idx.Value} {gothicBands[idx]}, ");
            }

            Console.WriteLine();
            Console.WriteLine("-> Using range.");

            foreach (var itm in gothicBands[0..2])
            {
                Console.Write(itm + ", ");
            }

            Console.WriteLine("/n");
        }
    }
}