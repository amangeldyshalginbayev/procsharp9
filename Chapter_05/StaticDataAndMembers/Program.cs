﻿using System;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");
            // SavingsAccount s1 = new SavingsAccount(50);
            // SavingsAccount s2 = new SavingsAccount(100);
            // //SavingsAccount s3 = new SavingsAccount(10000.75);
            //
            // Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");
            // SavingsAccount s3 = new SavingsAccount(10000.75);
            // Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");
            
            // SavingsAccount s1 = new SavingsAccount(50);
            // Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");
            //
            // SavingsAccount.SetInterestRate(0.08);
            //
            // SavingsAccount s2 = new SavingsAccount(100);
            // Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");

            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            Console.ReadLine();
        }
    }
}