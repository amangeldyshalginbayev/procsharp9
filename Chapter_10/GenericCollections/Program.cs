using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseGenericList();
            int[] myInts = { 9, 8, 7, 123, 0, 10 };
            Array.Sort<int>(myInts);

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        static void UseGenericList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");

            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black",50));
            Console.WriteLine(morePeople[0]);

            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];
            Console.WriteLine(sum);

            //moreInts.Add(new Person("","",0));
            
        }
    }
}