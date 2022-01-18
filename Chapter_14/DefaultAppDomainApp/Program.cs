using System;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Runtime.Loader;

namespace DefaultAppDomainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the default AppDomain *****");
            //DisplayDADStats();
            //ListAllAssembliesInAppDomain();
            //LoadAdditionalAssembliesDifferentContexts();
            LoadAdditionalAssembliesSameContext();
            
            Console.ReadLine();
        }

        static void DisplayDADStats()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            Console.WriteLine($"Name of this domain: {defaultAD.FriendlyName}");
            Console.WriteLine($"Id of domain in this process: {defaultAD.Id}");
            Console.WriteLine($"Is this the default domain?: {defaultAD.IsDefaultAppDomain()}");
            Console.WriteLine($"Base directory of this domain: {defaultAD.BaseDirectory}");
            Console.WriteLine("Setup information for this domain:");
            Console.WriteLine($"\t Application Base: {defaultAD.SetupInformation.ApplicationBase}");
            Console.WriteLine($"\t Target Framework: {defaultAD.SetupInformation.TargetFrameworkName}");
        }

        static void ListAllAssembliesInAppDomain()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            var loadedAssemblies = defaultAD.GetAssemblies().OrderBy(x => x.GetName().Name);
            Console.WriteLine($"***** Here are the assemblies loaded in {defaultAD.FriendlyName} *****\n");
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine($"-> Name: {a.GetName().Name}, Version: {a.GetName().Version}");
            }
        }

        static void LoadAdditionalAssembliesDifferentContexts()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLibrary1.dll");
            AssemblyLoadContext lc1 = new AssemblyLoadContext("NewContext1", false);
            var cl1 = lc1.LoadFromAssemblyPath(path);
            var c1 = cl1.CreateInstance("ClassLibrary1.Car");

            AssemblyLoadContext lc2 = new AssemblyLoadContext("NewContext2", false);
            var cl2 = lc2.LoadFromAssemblyPath(path);
            var c2 = cl2.CreateInstance("ClassLibrary1.Car");
            Console.WriteLine("*** Loading Additional Assemblies in Different Contexts ***");
            Console.WriteLine($"Assembly1.Equals(Assembly2) {cl1.Equals(cl2)}");
            Console.WriteLine($"Assembly1 == Assembly2 {cl1 == cl2}");
            Console.WriteLine($"Class1.Equals(Class2) {c1.Equals(c2)}");
            Console.WriteLine($"Class1 == Class2 {c1 == c2}");
        }

        static void LoadAdditionalAssembliesSameContext()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLibrary1.dll");
            AssemblyLoadContext lc1 = new AssemblyLoadContext(null, false);
            var cl1 = lc1.LoadFromAssemblyPath(path);
            var c1 = cl1.CreateInstance("ClassLibrary1.Car");
            var cl2 = lc1.LoadFromAssemblyPath(path);
            var c2 = cl2.CreateInstance("ClassLibrary1.Car");
            Console.WriteLine("*** Loading Additional Assemblies in Same Context ***");
            Console.WriteLine($"Assembly1.Equals(Assembly2) {cl1.Equals(cl2)}");
            Console.WriteLine($"Assembly1 == Assembly2 {cl1 == cl2}");
            Console.WriteLine($"Class1.Equals(Class2) {c1.Equals(c2)}");
            Console.WriteLine($"Class1 == Class2 {c1 == c2}");
        }
        
        
    }
}