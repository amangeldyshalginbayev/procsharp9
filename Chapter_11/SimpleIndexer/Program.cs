using System;
using System.Collections.Generic;
using System.Data;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Indexers *****");

            // PersonCollection myPeople = new PersonCollection();
            //
            // // Add objects with indexer syntax.
            // myPeople[0] = new Person("Homer", "Simpson", 40);
            // myPeople[1] = new Person("Marge", "Simpson", 38);
            // myPeople[2] = new Person("Lisa", "Simpson", 9);
            // myPeople[3] = new Person("Bart", "Simpson", 7);
            // myPeople[4] = new Person("Maggie", "Simpson", 2);
            //
            // // Now obtain and display each item using indexer.
            // for (int i = 0; i < myPeople.Count; i++)
            // {
            //     Console.WriteLine("Person number: {0}", i);
            //     Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
            //     Console.WriteLine("Age: {0}", myPeople[i].Age);
            //     Console.WriteLine();
            // }
            
            //UseGenericListOfPeople();

            // PersonCollectionStringIndexer personCollectionStringIndexer = new PersonCollectionStringIndexer();
            //
            // personCollectionStringIndexer["Homer"] = new Person("Homer", "Simpson", 40);
            // personCollectionStringIndexer["Marge"] = new Person("Marge", "Simpson", 38);
            //
            // Person marge = personCollectionStringIndexer["Marge"];
            // Console.WriteLine($"marge: {marge}");
            
            //MultiIndexerWithDataTable();
            
            

            Console.ReadLine();
        }

        public static void UseGenericListOfPeople()
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Lisa", "Simpson", 9));
            myPeople.Add(new Person("Bart", "Simpson", 7));
            
            myPeople[0] = new Person("Maggie", "Simpson", 2);
            
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }
        }

        static void MultiIndexerWithDataTable()
        {
            DataTable myTable = new DataTable();

            myTable.Columns.Add(new DataColumn("FirstName"));
            myTable.Columns.Add(new DataColumn("LastName"));
            myTable.Columns.Add(new DataColumn("Age"));

            myTable.Rows.Add("Mel", "Appleby", 60);

            Console.WriteLine($"First Name: {myTable.Rows[0][0]}");
            Console.WriteLine($"Last Name: {myTable.Rows[0][1]}");
            Console.WriteLine($"Age: {myTable.Rows[0][2]}");
        }
    }
}