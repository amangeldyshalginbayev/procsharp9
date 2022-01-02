using System;
using System.Collections;
using System.Collections.Generic;

namespace FunWithCollectionInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArrayOfInts = { 1, 6, 3, 8, 9 };

            List<int> myGenericList = new List<int> { 1, 2, 3 };

            ArrayList myList = new ArrayList { 1, 2, 3, 4, 5 };
        }
    }
}