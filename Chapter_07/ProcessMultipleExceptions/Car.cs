using System;

namespace ProcessMultipleExceptions
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
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(delta), "Speed must be greater than zero.");
            }
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

                    throw new CarIsDeadException($"{PetName} has overheated!", "You have a lead foot", DateTime.Now)
                    {
                        HelpLink = "http://www.CarsRUs.com"
                    };
                }

                Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}