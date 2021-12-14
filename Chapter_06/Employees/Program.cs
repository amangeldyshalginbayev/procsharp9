using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            // SalesPerson fred = new SalesPerson
            // {
            //     Age = 31, Name = "Fred", SalesNumber = 50
            // };
            //var john = new PtSalesPerson("John",18978,890,20,"2332390-122332-233",12);
            // Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            // double cost = chucky.GetBenefitCost();
            // Console.WriteLine($"Benefit Cost: {cost}");
            
            // Give each employee a bonus?
            // Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            // chucky.GiveBonus(300);
            // chucky.DisplayStats();
            // Console.WriteLine();
            // SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            // fran.GiveBonus(200);
            // fran.DisplayStats();
            //Employee employee = new Employee();
            //ExplicitCastExample();
            CastingWithAs();
            
            Console.ReadLine();
        }

        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 3000, 40_000, "111-11-1111", 5);
            GivePromotion((Manager)frank);

            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20_000, "111-12-1119", 1);
            GivePromotion(moonUnit);

            SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100_000, "111-12-1119", 90);
            GivePromotion(jill);
        }

        static void GivePromotion(Employee emp)
        {
            // Increase pay ...
            // Give new parking space in company garage ...
            Console.WriteLine($"{emp.Name} was promoted!");
        }

        static void GivePromotionWithIsCheck(Employee employee)
        {
            Console.WriteLine($"{employee.Name} was promoted!");

            if (employee is SalesPerson)
            {
                Console.WriteLine($"{employee.Name} made {((SalesPerson)employee).SalesNumber} sale/s!");
                Console.WriteLine();
            }
            else if (employee is Manager)
            {
                Console.WriteLine($"{employee.Name} had {((Manager)employee).StockOptions} stock options...");
                Console.WriteLine();
            }
        }

        static void GivePromotionWithIsCheckUpdated(Employee employee)
        {
            Console.WriteLine($"{employee.Name} was promoted!");

            if (employee is SalesPerson salesPerson)
            {
                Console.WriteLine($"{salesPerson.Name} made {salesPerson.SalesNumber} sale(s)!");
                Console.WriteLine();
            }
            else if (employee is Manager manager)
            {
                Console.WriteLine($"{manager.Name} had {manager.StockOptions} stock options...");
                Console.WriteLine();
            }
            else if (employee is var _)
            {
                Console.WriteLine($"Unable to promote {employee.Name}. Wrong employee type.");
            }
            
            // C# 9 pattern matching, very cool syntax!
            if (employee is not Manager and not SalesPerson)
            {
                Console.WriteLine($"Unable to promote {employee.Name}. Wrong employee type.");
                Console.WriteLine();
            }
        }
        
        static void ExplicitCastExample()
        {
            // explicit cast checked at runtime, this will compile, but throws InvalidCastException in runtime
            object frank = new Manager();
            try
            {
                Hexagon hex = (Hexagon)frank;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void CastingWithAs()
        {
            object[] things = { new Hexagon(), false, new Manager(), "Last thing" };

            foreach (var item in things)
            {
                Hexagon hex = item as Hexagon;
                if (hex == null)
                {
                    Console.WriteLine("Item is not a Hexagon.");
                }
                else
                {
                    hex.Draw();
                }
            }
        }

        static void GivePromotionWithPatternMatching(Employee employee)
        {
            Console.WriteLine($"{employee.Name} was promoted!");
            switch (employee)
            {
                case SalesPerson s when s.SalesNumber > 5:
                    Console.WriteLine($"{employee.Name} made more than 5 sales! Good job, {employee.Name}!");
                    break;
                case SalesPerson salesPerson:
                    Console.WriteLine($"{employee.Name} made {salesPerson.SalesNumber} sale(s)!");
                    break;
                case Manager manager:
                    Console.WriteLine($"{employee.Name} had {manager.StockOptions} stock options...");
                    break;
                case Employee _:
                    Console.WriteLine($"Unable to promote {employee.Name}. Wrong employee type.");
                    break;
            }

            Console.WriteLine();
        }
        
        
        
        
    }
}