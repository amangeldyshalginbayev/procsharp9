using System;

namespace StaticDataAndMembers
{
    public class SavingsAccount
    {
        public static double currInterestRate = 0.04;
        public double currBalance;

        public SavingsAccount(double currBalance)
        {
            currInterestRate = 0.04;
            this.currBalance = currBalance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        public static void SetInterestRate(double newRate) => currInterestRate = newRate;
        public static double GetInterestRate() => currInterestRate;
    }
}