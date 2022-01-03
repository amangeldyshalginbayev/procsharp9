namespace ForEachWithExtensionMethods
{
    public class Car
    {
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        public Car()
        {
        }

        public Car(string petName, int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
            PetName = petName;
        }
    }
}