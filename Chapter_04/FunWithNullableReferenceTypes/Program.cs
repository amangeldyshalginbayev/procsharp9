using System;

namespace FunWithNullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string? nullableString = null;
            TestClass? myNullableClass = null;
            TestClass myNonNullableClass = myNullableClass;
            
            #nullable disable
            TestClass anotherNullableClass = null;
            TestClass? badDefinition = null;
            string? anotherNullableString = null;
            #nullable restore
        }
    }
}