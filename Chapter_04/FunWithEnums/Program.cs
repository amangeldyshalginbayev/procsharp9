using System;

namespace FunWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums ****");

            // Console.WriteLine((int)EmpTypeEnum.Manager);
            //
            // Console.WriteLine((int)EmpTypeEnum.Grunt);

            // EmpTypeEnum emp = EmpTypeEnum.Contractor;
            // AskForBonus(emp);
            //
            // Console.WriteLine("EmpTypeEnum uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            //Console.WriteLine("EmpTypeEnum uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpTypeEnum)));
            // EmpTypeEnum emp = EmpTypeEnum.Contractor;
            // Console.WriteLine($"emp is a {emp}");
            // Console.WriteLine($"{emp} = {(byte)emp}");
            
            EvaluateEnum(EmpTypeEnum.Contractor);
            
            Console.ReadLine();
        }

        static void AskForBonus(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpTypeEnum.Grunt:
                    Console.WriteLine("You have got to be kidding... Tipa, ofigel?!");
                    break;
                case EmpTypeEnum.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpTypeEnum.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;  
            }
        }
        
        static void EvaluateEnum(System.Enum e) 
        {
            Console.WriteLine($"=> Information about {e.GetType().Name}");
            Console.WriteLine($"=> e.GetType() = {e.GetType()}");
            Console.WriteLine($"Underlying storage type: {Enum.GetUnderlyingType(e.GetType())}");

            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine($"This enum has {enumData.Length} members.");

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine($"Name: {enumData.GetValue(i)}, Value: {enumData.GetValue(i):D}");
            }
        }
    }
    
  
    
    enum EmpTypeEnum : byte
    {
        Manager = 102,
        Grunt, // = 103
        Contractor, // = 104
        VicePresident // = 105
    }
}