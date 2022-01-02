using System;

namespace CustomGenericMethods
{
    public static class SwapFunctions
    {
        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        public static void Swap(ref Person a, ref Person b)
        {
            (a, b) = (b, a);
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"You sent the Swap() method: {a.GetType()}");

            (a, b) = (b, a);
        }
    }
}