using System;
using System.Linq;
using System.Reflection;

namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my type viewer");
            string typeName = "";
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write("or enter Q to quit: ");

                typeName = Console.ReadLine();
                
                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    Type t = Type.GetType(typeName);
                    if (t == null && typeName.Equals("System.Console", StringComparison.OrdinalIgnoreCase))
                    {
                        t = typeof(System.Console);
                    }
                    
                    Console.WriteLine("");
                    //ListVariousStats(t);
                    //ListFields(t);
                    //ListProps(t);
                    ListMethods(t);
                    //ListInterfaces(t);
                    
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find type");
                }
            } while (true);
        }

        static void ListMethods(Type type)
        {
            Console.WriteLine("***** Methods *****");
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (var methodInfo in methodInfos)
            {
                string retVal = methodInfo.ReturnType.FullName;
                string paramInfo = "( ";
                foreach (var parameterInfo in methodInfo.GetParameters())
                {
                    paramInfo += $"{parameterInfo.ParameterType} {parameterInfo.Name} ";
                }
                paramInfo += " )";
                // Display basic method signature
                Console.WriteLine($"{retVal} {methodInfo.Name} {paramInfo}");
            }

            Console.WriteLine();

            // var methodNames = from n in type.GetMethods() select n.Name;
            // foreach (var name in methodNames)
            // {
            //     Console.WriteLine($"-> {name}");
            // }
            // Console.WriteLine();
        }

        static void ListFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var name in fieldNames)
            {
                Console.WriteLine($"-> {name}");
            }

            Console.WriteLine();
        }

        static void ListProps(Type t)
        {
            Console.WriteLine("***** Properties *****");
            var propNames = from p in t.GetProperties() select p.Name;
            foreach (var name in propNames)
            {
                Console.WriteLine($"-> {name}");
            }

            Console.WriteLine();
        }

        static void ListInterfaces(Type t)
        {
            Console.WriteLine("***** Interfaces *****");
            var interfaceNames = from i in t.GetInterfaces() select i.Name;
            foreach (var name in interfaceNames)
            {
                Console.WriteLine($"-> {name}");
            }

            Console.WriteLine();
        }

        static void ListVariousStats(Type t)
        {
            Console.WriteLine("***** Various statistics *****");
            Console.WriteLine($"Base class is: {t.BaseType}");
            Console.WriteLine($"Is type abstract? {t.IsAbstract}");
            Console.WriteLine($"Is type sealed? {t.IsSealed}");
            Console.WriteLine($"Is type generic? {t.IsGenericTypeDefinition}");
            Console.WriteLine($"Is type a class type? {t.IsClass}");
            Console.WriteLine();
        }

        
    }
}