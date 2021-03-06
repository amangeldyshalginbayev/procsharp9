namespace BasicInheritance
{
    public class Car
    {
        public readonly int MaxSpeed;
        private int _currSpeed;

        public Car(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        public Car()
        {
            MaxSpeed = 55;
        }

        public int Speed
        {
            get
            {
                return _currSpeed;
            }
            set
            {
                _currSpeed = value;
                if (_currSpeed > MaxSpeed)
                {
                    _currSpeed = MaxSpeed;
                }
            }
        }
    }
}