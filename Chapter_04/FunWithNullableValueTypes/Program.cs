using System;

namespace FunWithNullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Value Types *****\n");
            // DatabaseReader dr = new DatabaseReader();
            // int? i = dr.GetIntFromDatabase();
            //
            // if (i.HasValue)
            // {
            //     Console.WriteLine($"Value of 'i' is: {i.Value}");
            // }
            // else
            // {
            //     Console.WriteLine("Value of 'i' is undefined.");
            // }
            //
            // bool? b = dr.GetBoolFromDatabase();
            // if (b != null)
            // {
            //     Console.WriteLine($"Value of 'b' is: {b.Value}");
            // }
            // else
            // {
            //     Console.WriteLine($"Value of 'b' is undefined.");
            // }

            // DatabaseReader dr = new DatabaseReader();
            //
            // int myData = dr.GetIntFromDatabase() ?? 100;
            // Console.WriteLine($"Value of myData: {myData}");

            // int? nullableInt = null;
            // nullableInt ??= 12;
            // nullableInt ??= 14;
            // Console.WriteLine($"nullableInt: {nullableInt}");
            
            TesterMethod(null);
            TesterMethod(new string[]{"hi"});

            Console.ReadLine();
        }

        static void LocalNullableVariables()
        {
            int? nullableInt = 10;
            double? nullableDouble = 10;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
        }
        
        static void LocalNullableVariablesUsingNullable()
        {
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }
        
        static void TesterMethod(string[] args)
        {
            // We should check for null before accessing the array data!
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
        }
    }
}