using System;

namespace CustomEnumeratorWithYield
{
    public class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;

        private readonly Radio _theMusicBox = new Radio();

        public Car()
        {
        }

        public Car(string petName, int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
            PetName = petName;
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
    }
}