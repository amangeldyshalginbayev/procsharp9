using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");
            
            // Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
            // actionTarget("Action Message!", ConsoleColor.Magenta, 5);

            Func<int, int, int> funcTarget = Add;
            int result = funcTarget(12, 8);
            Console.WriteLine($"12 + 8 = {result}");

            Func<int, int, string> funcTarget2 = SumToString;
            string sum = funcTarget2(1, 99);
            Console.WriteLine($"1 + 99 = {sum}");

            Console.ReadLine();
        }

        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = previousColor;
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}