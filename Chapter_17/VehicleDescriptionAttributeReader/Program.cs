using System;
using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
            ReflectOnAttributesUsingEarlyBinding();

            Console.ReadLine();

        }

        static void ReflectOnAttributesUsingEarlyBinding()
        {
            Type t = typeof(Winnebago);

            object[] customAtts = t.GetCustomAttributes(false);

            foreach (VehicleDescriptionAttribute a in customAtts)
            {
                Console.WriteLine($"-> {a.Description}");
            }
        }
    }
}