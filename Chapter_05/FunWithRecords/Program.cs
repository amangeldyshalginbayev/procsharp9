using System;

namespace FunWithRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Records! *****/n");

            Car myCar = new Car
            {
                Make = "Honda",
                Model = "Pilot",
                Color = "Blue"
            };

            Console.WriteLine("My car: ");
            DisplayCarStats(myCar);
            Console.WriteLine();

            Car anotherMyCar = new Car("Honda", "Pilot", "Blue");
            Console.WriteLine("Another variable for my car: ");
            DisplayCarStats(anotherMyCar);
            Console.WriteLine();

            //myCar.Color = "Red";

            Console.WriteLine("/********** RECORDS **********/");
            CarRecord myCarRecord = new CarRecord
            {
                Make = "Honda",
                Model = "Pilot",
                Color = "Blue"
            };
            Console.WriteLine("My car: ");
            DisplayCarRecordStats(myCarRecord);
            Console.WriteLine();

            CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
            Console.WriteLine("Another variable for my car: ");
            Console.WriteLine(anotherMyCarRecord.ToString());
            Console.WriteLine();

            //myCarRecord.Color = "Red";
            
            // Equality
            Console.WriteLine($"Cars are the same? {myCar.Equals(anotherMyCar)}");
            Console.WriteLine($"Cars are the same reference? {ReferenceEquals(myCar, anotherMyCar)}");
            
            // Equality of records
            Console.WriteLine("Equality of records: ");
            Console.WriteLine($"CarRecords are the same? {myCarRecord.Equals(anotherMyCarRecord)}");
            Console.WriteLine($"CarRecords are the same reference? {ReferenceEquals(myCarRecord,anotherMyCarRecord)}");
            Console.WriteLine($"CarRecords are the same? {myCarRecord == anotherMyCarRecord}");
            Console.WriteLine($"CarRecords are not the same? {myCarRecord != anotherMyCarRecord}");
            
            // Copying record types using with expression
            CarRecord ourOtherCar = myCarRecord with { Model = "Odyssey" };
            Console.WriteLine("My copied car:");
            Console.WriteLine(ourOtherCar.ToString());

            Console.ReadLine();

        }

        static void DisplayCarStats(Car car)
        {
            Console.WriteLine($"Car Make: {car.Make}");
            Console.WriteLine($"Car Model: {car.Model}");
            Console.WriteLine($"Car Color: {car.Color}");
        }

        static void DisplayCarRecordStats(CarRecord car)
        {
            Console.WriteLine(car);
        }
    }
}