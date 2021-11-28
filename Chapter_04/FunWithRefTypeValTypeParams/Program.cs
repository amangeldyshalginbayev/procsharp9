using System;

namespace FunWithRefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("***** Passing Person object by value *****");
            // Person fred = new Person("Fred",12);
            // Console.WriteLine("\nBefore by value call, Person is:");
            // fred.Display();
            //
            // SendAPersonByValue(fred);
            // Console.WriteLine("\nAfter by value call, Person is:");
            // fred.Display();
            
            Console.WriteLine("***** Passing Person object by reference *****");
            Person mel = new Person("Mel", 23);
            Console.WriteLine("Before by ref call, Person is:");
            mel.Display();
            SendAPersonByReference(ref mel);
            Console.WriteLine("After by ref call, Person is:");
            mel.Display();
            
            Console.ReadLine();
        }

        static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;

            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 555;

            p = new Person("Nikki", 999);
        }
    }
}