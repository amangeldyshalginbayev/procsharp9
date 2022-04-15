using System;
using System.IO;
using System.Reflection;

namespace LateBindingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Late Binding *****");

            Assembly a = null;

            try
            {
                Console.WriteLine($"Current app directory: [{Directory.GetCurrentDirectory()}]");
                a = Assembly.LoadFrom("CarLibrary.dll");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            if (a != null)
            {
                //CreateUsingLateBinding(a);
                InvokeMethodWithArgsUsingLateBinding(a);
            }

            Console.ReadLine();
        }

        static void CreateUsingLateBinding(Assembly a)
        {
            try
            {
                Type miniVanType = a.GetType("CarLibrary.MiniVan");
                object miniVanObject = Activator.CreateInstance(miniVanType);
                Console.WriteLine($"Created a [{miniVanObject}] using late binding!");

                MethodInfo methodInfo = miniVanType.GetMethod("TurboBoost");
                // null for no parameters
                methodInfo.Invoke(miniVanObject, null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void InvokeMethodWithArgsUsingLateBinding(Assembly asm)
        {
            try
            {
                Type sportsCarType = asm.GetType("CarLibrary.SportsCar");
                object sportsCarObject = Activator.CreateInstance(sportsCarType);
                MethodInfo methodInfo = sportsCarType.GetMethod("TurnOnRadio");
                methodInfo.Invoke(sportsCarObject, new object[] { true, 2 });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}