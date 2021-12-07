using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation! *****/n");
            // Employee employee = new Employee("Marvin", 456, 30_000);
            // employee.GiveBonus(1000);
            // employee.DisplayStats();
            //
            // employee.SetName(null);
            // Console.WriteLine($"Employee is named: {employee.GetName()}");
            //
            // Employee employee2 = new Employee();
            // employee2.SetName("Xena the warrior princess");
            // Employee joe = new Employee();
            // joe.Age++;
            // joe.DisplayStats();
            
            Employee emp = new Employee("Marvin",123,1000,45,"111-11-1111",EmployeePayTypeEnum.Salaried);
            Console.WriteLine(emp.Pay);
            emp.GiveBonus(100);
            Console.WriteLine(emp.Pay);
            emp.DisplayStats();
            Console.ReadLine();
        }
    }
}