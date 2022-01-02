using System;
using System.Collections;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleBoxUnboxOperation();
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));
            
            //myPeople.AddPerson("Andrew");

            foreach (Person p in myPeople)
            {
                Console.WriteLine(p);
            }
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;

            object boxedInt = myInt;

            int unboxedInt = (int)boxedInt;

            try
            {
                long unboxedLong = (long)boxedInt;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        static void WorkWithArrayList()
        {
            // Value types are automatically boxed when
            // passed to a method requesting an object.
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            
            
            // Unboxing occurs when an object is converted back to stack-based data.
            int i = (int)myInts[0];
            // Now it is reboxed, as WriteLine() requires object types!
            Console.WriteLine("Value of your int: {0}", i);
        }
    }
}