using System;
using System.Collections.Generic;
using System.Linq;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");

            ProductInfo[] itemsInStock = new[]
            {
                new ProductInfo { Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24 },
                new ProductInfo { Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100 },
                new ProductInfo { Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120 },
                new ProductInfo { Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2 },
                new ProductInfo { Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100 },
                new ProductInfo { Name = "Classic Valpo Pizza", Description = "Everyone lovespizza!", NumberInStock = 73 }
            };

            //SelectEverything(itemsInStock);
            //ListNames(itemsInStock);
            //GetOverStock(itemsInStock);
            //GetNamesAndDescriptions(itemsInStock);

            // Array objects = GetProjectedSubset(itemsInStock);
            // foreach (var o in objects)
            // {
            //     Console.WriteLine(o);
            // }
            
            //GetNamesAndDescriptionsTyped(itemsInStock);
            //GetCountFromQuery();
            //ReverseEverything(itemsInStock);
            //AlphabetizeProductNames(itemsInStock);
            //DisplayDiff();
            //DisplayIntersection();
            //DisplayUnion();
            //DisplayConcat();
            //DisplayConcatNoDuplicates();
            AggregateOperations();
            
            
            
            
            Console.ReadLine();
        }

        static void SelectEverything(ProductInfo[] products)
        {
            Console.WriteLine("All product details:");
            var allProducts = from p in products select p;

            foreach (var product in allProducts)
            {
                Console.WriteLine(product.ToString());
            }
        }

        static void ListNames(ProductInfo[] products)
        {
            Console.WriteLine("Only product names:");
            var names = from p in products select p.Name;

            foreach (var name in names)
            {
                Console.WriteLine($"Name: {name}");
            }
        }

        static void GetOverStock(ProductInfo[] products)
        {
            var overstock = from p in products where p.NumberInStock > 25 select p;

            foreach (var c in overstock)
            {
                Console.WriteLine(c.ToString());
            }
        }

        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            var nameDesc = from p in products select new { p.Name, p.Description };

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item);
            }
        }

        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };

            return nameDesc.ToArray();
        }

        static void GetNamesAndDescriptionsTyped(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            IEnumerable<ProductInfoSmall> nameDescs = from p in products
                select new ProductInfoSmall { Name = p.Name, Description = p.Description };

            foreach (var item in nameDescs)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void GetCountFromQuery()
        {
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            int number = (from g in currentVideoGames where g.Length > 6 select g).Count();

            Console.WriteLine($"{number} items honor the LINQ query.");
        }

        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Product in reverse:");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            var subset = from p in products orderby p.Name select p;

            Console.WriteLine("Ordered by Name:");

            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void DisplayDiff()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec"};

            var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);

            Console.WriteLine("Here is what you don't have but, but I do:");
            foreach (var s in carDiff)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayIntersection()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec"};

            var carIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);

            Console.WriteLine("Here is what we have in common:");
            foreach (var s in carIntersect)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayUnion()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec"};

            var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);

            Console.WriteLine("Here is everything:");
            foreach (var s in carUnion)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayConcat()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec"};

            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);

            Console.WriteLine("Here is concatenation:");
            foreach (var s in carConcat)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayConcatNoDuplicates()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec"};

            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);

            Console.WriteLine("Here is concatenation without duplicates:");
            foreach (var s in carConcat.Distinct())
            {
                Console.WriteLine(s);
            }
        }

        static void AggregateOperations()
        {
            double[] winterTemps = { -17, -15, -30, -8, -22, -8, -18};

            Console.WriteLine($"Warmest day temperature: {winterTemps.Max()}");
            Console.WriteLine($"Coldest day temperature: {winterTemps.Min()}");
            Console.WriteLine($"Average temperature: {winterTemps.Average()}");
        }
    }
}