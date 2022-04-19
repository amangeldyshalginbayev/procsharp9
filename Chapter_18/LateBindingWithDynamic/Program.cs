using System;
using System.Reflection;
using Microsoft.CSharp.RuntimeBinder;

namespace LateBindingWithDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //AddWithReflection();
            AddWithDynamic();
        }

        static void AddWithReflection()
        {
            Assembly asm = Assembly.LoadFrom("MathLibrary.dll");

            try
            {
                Type math = asm.GetType("MathLibrary.SimpleMath");

                object obj = Activator.CreateInstance(math);

                MethodInfo mi = math.GetMethod("Add");

                object[] args = { 10, 70 };

                Console.WriteLine($"Result is: {mi.Invoke(obj, args)}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void AddWithDynamic()
        {
            Assembly asm = Assembly.LoadFrom("MathLibrary.dll");

            try
            {
                Type math = asm.GetType("MathLibrary.SimpleMath");

                dynamic obj = Activator.CreateInstance(math);

                Console.WriteLine($"Result is: {obj.Add(10, 70)}");
            }
            catch (RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}