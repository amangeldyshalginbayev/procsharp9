using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FunWithObservableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52 },
                new Person{ FirstName = "Kevin", LastName = "Key", Age = 48 }
            };

            people.CollectionChanged += people_CollectionChanged;
            
            people.Add(new Person("Fred", "Smith",32));
            people.RemoveAt(0);
            
        }

        static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"Action for this event: {e.Action}");

            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are OLD items");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine();
            }

            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p);
                }
            }
        }
        
    }
}