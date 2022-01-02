using System;
using System.Collections;

namespace NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingArrayList();
        }

        static void UsingArrayList()
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] {"First", "Second", "Third"});
            Console.WriteLine($"The collection has {strArray.Count} items");
            Console.WriteLine();
            strArray.Add("Fourth");
            Console.WriteLine($"The collection has {strArray.Count} items");

            foreach (string s in strArray)
            {
                Console.WriteLine($"Entry: {s}");
            }

            Console.WriteLine();

        }
    }
}