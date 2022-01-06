using System;

namespace CarEvents
{
    public class Car
    {
        private bool _carIsDead;

        public string Name;
        private int _maxSpeed;
        private int _currentSpeed;

        public Car(string name, int maxSpeed, int currentSpeed)
        {
            Name = name;
            _maxSpeed = maxSpeed;
            _currentSpeed = currentSpeed;
        }


        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
        
        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Exploded?.Invoke(this,new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                _currentSpeed += delta;

                if (10 == _maxSpeed - _currentSpeed)
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
                }

                if (_currentSpeed >= _maxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine($"CurrentSpeed = {_currentSpeed}");
                }
            }
        }
    }
}