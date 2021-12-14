using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");

            // Person p1 = new Person();
            //
            // Console.WriteLine($"ToString: {p1.ToString()}");
            // Console.WriteLine($"Hash Code: {p1.GetHashCode()}");
            // Console.WriteLine($"Type: {p1.GetType()}");
            //
            // Person p2 = p1;
            // object o = p2;
            //
            // if (o.Equals(p1) && p2.Equals(o))
            // {
            //     Console.WriteLine("Same instance!");
            // }

            // Person p1 = new Person("Homer", "Simpson", 50, "111-11-1111");
            // Person p2 = new Person("Homer", "Simpson", 50, "111-11-1111");
            //
            // Console.WriteLine($"p1.ToString() = {p1}");
            // Console.WriteLine($"p2.ToString() = {p2}");
            //
            // Console.WriteLine($"p1 = p2? : {p1.Equals(p2)}");
            //
            // Console.WriteLine($"Same hash codes? : {p1.GetHashCode() == p2.GetHashCode()}");
            // Console.WriteLine();
            //
            // p2.Age = 45;
            // Console.WriteLine($"p1.ToString() = {p1}");
            // Console.WriteLine($"p2.ToString() = {p2}");
            // Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");
            //
            // Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");
            
            StaticMembersOfObject();

            Console.ReadLine();
        }

        static void StaticMembersOfObject()
        {
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            Console.WriteLine($"P3 and P4 have same state: {object.Equals(p3,p4)}");
            Console.WriteLine($"P3 and P4 are pointing to the same object: {object.ReferenceEquals(p3,p4)}");
        }
    }
}