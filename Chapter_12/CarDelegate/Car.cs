using System;

namespace CarDelegate
{
    public class Car
    {
        // Internal state data.
        public string PetName { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public int CurrentSpeed { get; set; }
        // Is the car alive or dead?
        private bool _carIsDead;

        public Car()
        {
        }

        public Car(string petName, int maxSpeed, int currentSpeed)
        {
            PetName = petName;
            MaxSpeed = maxSpeed;
            CurrentSpeed = currentSpeed;
        }

        public delegate void CarEngineHandler(string msgForCaller);

        private CarEngineHandler _listOfHandlers;

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                _listOfHandlers?.Invoke("Sorry this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                if (MaxSpeed - CurrentSpeed > 0 && MaxSpeed - CurrentSpeed <= 10)
                {
                    _listOfHandlers?.Invoke("Careful buddy. Gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
                }
            }
        }

        public void CheckEventHandler()
        {
            if (_listOfHandlers == null)
            {
                Console.WriteLine("Event handler list is null");
            }
            else
            {
                Console.WriteLine("Event handler list has value");
            }
        }
    }
}