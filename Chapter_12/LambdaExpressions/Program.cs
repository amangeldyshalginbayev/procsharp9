using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****");
            
            //TraditionalDelegateSyntax();
            //AnonymousMethodSyntax();
            //LambdaExpressionSyntax();
            //LambdaWithMultipleParameters();
            UsingStaticWithLambdaExpressions();

            Console.ReadLine();
        }

        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            Predicate<int> callBack = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callBack);

            Console.WriteLine("Here are your even numbers:");
            foreach (var evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }

            Console.WriteLine();
        }

        static void AnonymousMethodSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Now, use an anonymous method.
            List<int> evenNumbers =
                list.FindAll(delegate(int i) { return (i % 2) == 0; } );
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        static void LambdaExpressionSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Now, use a C# lambda expression.
            //List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
            
            List<int> evenNumbers = list.FindAll(i =>
            {
                Console.WriteLine($"Value of i is currently: {i}");
                bool isEven = i % 2 == 0;
                return isEven;
            });
            
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        static bool IsEvenNumber(int i)
        {
            return (i % 2 == 0);
        }

        static void LambdaWithMultipleParameters()
        {
            SimpleMath sm = new SimpleMath();
            sm.SetMathHandler((string msg, int result) =>
            {
                Console.WriteLine($"Message: {msg}, Result: {result}");
            });
            
            sm.Add(15,5);
        }

        static void UsingStaticWithLambdaExpressions()
        {
            var outerVariable = 0;

            Func<int, int, bool> DoWork = /*static*/ (x, y) =>
            {
                outerVariable++; // in case static we cant access outerVariable
                return true;
            };
            
            Console.WriteLine($"DoWork(3,2) = {DoWork(1, 1)}");
            Console.WriteLine($"Outer variable now: {outerVariable}");
        }
    }
}