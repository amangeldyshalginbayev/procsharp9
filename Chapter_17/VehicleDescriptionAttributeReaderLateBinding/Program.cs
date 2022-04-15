using System;
using System.IO;
using System.Reflection;

namespace VehicleDescriptionAttributeReaderLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
            Console.WriteLine($"Current directory: [{Directory.GetCurrentDirectory()}]");
            ReflectAttributesUsingLateBinding();

            Console.ReadLine();
        }
        
        static void ReflectAttributesUsingLateBinding()
        {
            try
            {
                // Load the local copy of AttributedCarLibrary.
                Assembly asm = Assembly.LoadFrom("AttributedCarLibrary.dll"); // assembly name

                // Get type info of VehicleDescriptionAttribute.
                Type vehicleDescType = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute"); // type name using namespace

                // Get type info of the Description property.
                PropertyInfo propDesc = vehicleDescType.GetProperty("Description"); // property name

                // Get all types in the assembly.
                Type[] types = asm.GetTypes();

                // Iterate over each type and obtain any VehicleDescriptionAttributes.
                foreach (Type t in types)
                {
                    object[] objs = t.GetCustomAttributes(vehicleDescType, false);

                    // Iterate over each VehicleDescriptionAttribute and print
                    // the description using late binding.
                    foreach (object o in objs)
                    {
                        Console.WriteLine("-> {0}: {1}\n", t.Name, propDesc.GetValue(o, null)); // 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}