namespace PublicDelegateProblem
{
    public class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);

        public CarEngineHandler ListOfHandlers;

        public void Accelerate(int delta)
        {
            if (ListOfHandlers != null)
            {
                ListOfHandlers("Sorry, this car is dead...");
            }
        }
    }
}