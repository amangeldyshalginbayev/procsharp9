using System;
using System.Collections.Generic;
using Microsoft.CSharp.RuntimeBinder;

namespace DynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChangeDynamicDataType();
            InvokeMembersOnDynamicData();
            
            static void ImplicitlyTypedVariable()
            {
                var a = new List<int> { 90 };

                // compile error
                //a = "some text";
            }

            static void UseObjectVariable()
            {
                object o = new Person() { FirstName = "Mike", LastName = "Tyson" };

                Console.WriteLine($"Persons first name is: {((Person)o).FirstName}");
            }

            static void ChangeDynamicDataType()
            {
                dynamic t = "Hello";
                Console.WriteLine($"t is of type: {t.GetType()}");

                t = false;
                Console.WriteLine($"t is of type: {t.GetType()}");

                t = new List<int>();
                Console.WriteLine($"t is of type: {t.GetType()}");

            }

            static void InvokeMembersOnDynamicData()
            {
                dynamic textData1 = "Hello";
                Console.WriteLine(textData1.ToUpper());

                try
                {
                    Console.WriteLine(textData1.toupper());
                    Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
                }
                catch (RuntimeBinderException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

        }
    }
}