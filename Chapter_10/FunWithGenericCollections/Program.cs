using System;
using System.Collections.Generic;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseGenericStack();
            //UseGenericQueue();
            //UseSortedSet();
            //UseDictionary();
            
        }

        static void UseGenericList()
        {
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 },
                new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 }
            };

            Console.WriteLine($"Items in list: {people.Count}");

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);
            // Copy data into a new array.
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine("First Names: {0}", p.FirstName);
            }
        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Now look at the top item, pop it, and look again.
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            try
            {
                Console.WriteLine("\nnFirst person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }
        }

        static void UseGenericQueue()
        {
            // Make a Q with three people.
            Queue<Person> peopleQ = new();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            // Peek at first person in Q.
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);
            // Remove each person from Q.
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            // Try to de-Q again?
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }

            //Local helper function
            static void GetCoffee(Person p)
            {
                Console.WriteLine("{0} got coffee!", p.FirstName);
            }
        }

        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName= "Homer", LastName="Simpson", Age=47},
                new Person {FirstName= "Marge", LastName="Simpson", Age=45},
                new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
                new Person {FirstName= "Bart", LastName="Simpson", Age=8}
            };

            foreach (var person in setOfPeople)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
            
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }

        static void UseDictionary()
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            
            people.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 }); 
            people.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 }); 
            people.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            Person homer = people["Homer"];
            Console.WriteLine(homer);
            
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                { "Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 } },
                { "Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
                { "Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
            };

            Person lisa = peopleB["Lisa"];
            Console.WriteLine(lisa);
        }
        
        
    }
}