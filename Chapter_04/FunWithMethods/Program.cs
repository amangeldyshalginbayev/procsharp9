using System;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Methods.");
            // int x = 9, y = 10;
            // Console.WriteLine($"Before call: X: {x}, Y: {y}");
            // Console.WriteLine($"Answer is: {Add(x, y)}");
            // Console.WriteLine($"After call: X: {x}, Y: {y}");

            // int ans = 0;
            // Console.WriteLine($"Before call ans: {ans}");
            // AddUsingOutParam(90,90,out ans);
            // Console.WriteLine($"After call ans: {ans}");
            
            // C# 7 allows for out parameters to be declared in the method call
            // AddUsingOutParam(90,90,out int ans);
            // Console.WriteLine($"90 + 90 = {ans}");
            
            // FillTheseValues(out int i, out string str, out bool b);
            // Console.WriteLine("Int is: {0}", i);
            // Console.WriteLine("String is: {0}", str);
            // Console.WriteLine("Boolean is: {0}", b);

            // string str1 = "Flip";
            // string str2 = "Flop";
            //
            // Console.WriteLine($"Before: {str1}, {str2}");
            // SwapStrings(ref str1, ref str2);
            // Console.WriteLine($"After: {str1}, {str2}");
            //Console.WriteLine(Add2(10,25));

            // Pass comma-delimited values
            // double average;
            // average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            // Console.WriteLine($"Average of data is: {average}");
            
            // Pass array of doubles
            // double[] data = { 4.0, 3.2, 5.7};
            // average = CalculateAverage(data);
            // Console.WriteLine($"Average of data is: {average}");
            
            // Average of 0 is 0!
            //Console.WriteLine($"Average of data is: {CalculateAverage()}");
           
            // EnterLogData("Oh no! Grid can't find data.");
            // EnterLogData("Oh no! I can't find the payroll data","CFO");
            
            DisplayFancyMessage(message: "Wow! Very Fancy indeed!", textColor:ConsoleColor.Magenta,backgroundColor:ConsoleColor.Yellow);
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            int ans = x + y;

            x = 10000;
            y = 88888;
            return ans;
        }

        // Output parameters must be assigned by the called method.
        static void AddUsingOutParam(int x, int y, out int ans)
        {
            ans = x + y;
        }
        
        // Returning multiple output parameters
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            (s1, s2) = (s2, s1);
        }

        static int Add2(int x, int y)
        {
            x = 10000;
            y = 88888;
            int ans = x + y;
            return ans;
        }

        // in - pass by reference in any case (value type, reference type) AND read only mode inside method
        static int AddReadOnly(in int x, in int y)
        {
            // compiler error
            // x = 10000;
            // y = 88888;
            int ans = x + y;
            return ans;
        }

        static double CalculateAverage(params  double[] values)
        {
            Console.WriteLine($"You sent me {values.Length} doubles.");

            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return (sum / values.Length);
        }

        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine($"Error:{message}");
            Console.WriteLine($"Owner of Error: {owner}");
        }
        
        // Error! Default arguments must be compile time constant!
        // static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = DateTime.Now)
        // {
        //     Console.Beep();
        //     Console.WriteLine("Error: {0}", message);
        //     Console.WriteLine("Owner of Error: {0}", owner);
        //     Console.WriteLine("Time of Error: {0}", timeStamp);
        // }

        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}