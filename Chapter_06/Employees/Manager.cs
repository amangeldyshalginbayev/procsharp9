using System;

namespace Employees
{
    public class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numbOfOpts) : base(fullName,
            empId, currPay, age, ssn, EmployeePayTypeEnum.Salaried)
        {
            StockOptions = numbOfOpts;
        }

        public Manager()
        {
            Console.WriteLine("Manager() called.");
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Number of Stock Options: {StockOptions}");
        }
    }
}