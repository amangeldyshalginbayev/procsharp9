using System;

namespace Employees
{
    public sealed class PtSalesPerson : SalesPerson
    {
        public PtSalesPerson(string empName, int empId, float currPay, int empAge, string empSsn, int salesNumber) : base(empName, empId, currPay, empAge, empSsn, salesNumber)
        {
            Console.WriteLine("PtSalesPerson(string empName, int empId, float currPay, int empAge, string empSsn, int salesNumber) called.");
        }
        
        
    }
}