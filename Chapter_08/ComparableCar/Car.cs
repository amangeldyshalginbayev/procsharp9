using System;
using System.Collections;

namespace ComparableCar
{
    public class Car : IComparable
    {
        public int CarID { get; set; }
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;

        private readonly Radio _theMusicBox = new Radio();

        public static IComparer SortByPetName => new PetNameComparer();

        public Car()
        {
        }

        public Car(string petName, int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
            PetName = petName;
        }

        public Car(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            PetName = name;
            CarID = id;
        }

        public void CrankTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine($"{PetName} is out of order...");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    Console.WriteLine($"{PetName} has overheated!");
                    CurrentSpeed = 0;
                    _carIsDead = true;

                    throw new Exception($"{PetName} has overheated!")
                    {
                        HelpLink = "http://www.CarsRUs.com",
                        Data =
                        {
                            {"TimeStamp", $"The car exploded at {DateTime.Now}. TimeZone: {TimeZoneInfo.Local}."},
                            {"Cause", "You have a lead foot."}
                        }
                    };
                }

                Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
            }
        }

        // int IComparable.CompareTo(object obj)
        // {
        //     if (obj is Car tempCar)
        //     {
        //         if (this.CarID > tempCar.CarID)
        //         {
        //             return 1;
        //         }
        //
        //         if (this.CarID < tempCar.CarID)
        //         {
        //             return -1;
        //         }
        //
        //         return 0;
        //     }
        //
        //     throw new ArgumentException("Parameter is not a Car.");
        // }

        int IComparable.CompareTo(object obj)
        {
            if (obj is Car tempCar)
            {
                return this.CarID.CompareTo(tempCar.CarID);
            }

            throw new ArgumentException("Parameter is not a Car.");
        }

    }
}