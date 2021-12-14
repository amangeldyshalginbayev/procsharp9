using System;

namespace Employees
{
    public abstract partial class Employee
    {
        
        // Constructors.
        public Employee()
        {
            Console.WriteLine("Employee() is called.");
        }

        public Employee(string name, int id, float pay, string empSsn) : this(name, id, pay, 0, empSsn,EmployeePayTypeEnum.Salaried)
        {
        }

        public Employee(string empName, int empId, float currPay, int empAge, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = empName;
            Id = empId;
            Pay = currPay;
            Age = empAge;
            SocialSecurityNumber = empSsn;
            PayType = payType;
            Console.WriteLine("Employee(string empName, int empId, float currPay, int empAge, string empSsn, EmployeePayTypeEnum payType) called.");
        }

        // Methods.
        public virtual void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission } => Pay += .10f * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40f * amount / 2080f,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0
            };
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
            Console.WriteLine("PayType: {0}", PayType);
        }
    }
}