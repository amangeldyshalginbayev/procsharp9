using System;
using System.IO;
using System.Reflection;

namespace ExternalAssemblyReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** External Assembly Viewer *****");
            string asmName = "";
            Assembly asm = null;
            do
            {
                Console.WriteLine("\nEnter an assembly to evaluate");
                Console.Write("or enter Q to quit: ");
                asmName = Console.ReadLine();
                if (asmName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                //Console.WriteLine($"Asm name: [{asmName}]");
                try
                {
                    //Console.WriteLine($"Current path: {Directory.GetCurrentDirectory()}");
                    asm = Assembly.LoadFrom(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find assembly.");
                }

            } while (true);
        }

        static void DisplayTypesInAsm(Assembly assembly)
        {
            Console.WriteLine("\n***** Types in Assembly *****");
            Console.WriteLine($"->{assembly.FullName}");
            Type[] types = assembly.GetTypes();
            foreach (var t in types)
            {
                Console.WriteLine($"Type: {t}");
            }

            Console.WriteLine("");
        }
    }
}