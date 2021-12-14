using System;

namespace Employees
{
    public class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson(string empName, int empId, float currPay, int empAge, string empSsn, int salesNumber) : base(empName, empId, currPay, empAge, empSsn, EmployeePayTypeEnum.Commission)
        {
            SalesNumber = salesNumber;
            Console.WriteLine("SalesPerson(string empName, int empId, float currPay, int empAge, string empSsn, int salesNumber) called.");
        }

        public SalesPerson()
        {
            Console.WriteLine("SalesPerson() called.");
        }

        public sealed override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Number of Sales: {SalesNumber}");
        }
    }
}