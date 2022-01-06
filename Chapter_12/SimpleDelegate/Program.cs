using System;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Type *****");

            BinaryOp b = new BinaryOp(SimpleMath.Add);
            //BinaryOp b2 = new BinaryOp(SimpleMath.SquareNumber);
            //Console.WriteLine($"10 + 10 = {b(10,10)}");

            SimpleMath sm = new SimpleMath();
            BinaryOp b3 = new BinaryOp(sm.AddInstanceMethod);
            
            DisplayDelegateInfo(b3);

            Console.ReadLine();

        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (var d in delObj.GetInvocationList())
            {
                Console.WriteLine($"Method name: {d.Method}");
                Console.WriteLine($"Type name: {d.Target}");
            }
        }
    }

    public delegate int BinaryOp(int a, int b);
}