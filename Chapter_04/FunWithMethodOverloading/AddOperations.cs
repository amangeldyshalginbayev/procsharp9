using System;

namespace FunWithMethodOverloading
{
    public static class AddOperations
    {
        // Overloaded Add() method.
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static long Add(long x, long y)
        {
            Console.WriteLine("Add(long x, long y) called.");
            return x + y;
        }
    }
}