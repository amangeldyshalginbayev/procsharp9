﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over generic collections *****");

            List<Car> myCars = new List<Car>()
            {
                new Car { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
                new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
                new Car { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
                new Car { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
                new Car { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
            };

            //GetFastCars(myCars);
            //GetFastBMWs(myCars);
            //LINQOverArrayList();
            //OfTypeAsFilter();
            

            Console.ReadLine();
        }

        static void GetFastCars(List<Car> myCars)
        {
            var fastCars = from c in myCars where c.Speed > 55 select c;

            foreach (var car in fastCars)
            {
                Console.WriteLine($"{car.PetName} is going too fast!");
            }
        }

        static void GetFastBMWs(List<Car> myCars)
        {
            var fastCars = from c in myCars where c.Speed > 90 && c.Make == "BMW" select c;

            foreach (var car in fastCars)
            {
                Console.WriteLine($"{car.PetName} is going too fast!");
            }
        }

        static void LINQOverArrayList()
        {
            Console.WriteLine("***** LINQ over ArrayList *****");
            ArrayList myCars = new ArrayList()
            {
                new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };

            var myCarsEnum = myCars.OfType<Car>();

            var fastCars = from c in myCarsEnum where c.Speed > 55 select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine($"{car.PetName} is going too fast!");
            }
        }

        static void OfTypeAsFilter()
        {
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] {10, 400, 8, false, new Car(), "string value", 44.5});

            var myInts = myStuff.OfType<int>();

            foreach (var i in myInts)
            {
                Console.WriteLine($"Int value: {i}");
            }
        }
        
        
    }
}