// using System.Runtime.CompilerServices;
//
// [assembly:InternalsVisibleTo("CSharpCarClient")]
namespace CarLibrary
{
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineStateEnum State = EngineStateEnum.EngineAlive;

        public EngineStateEnum EngineState => State;

        public abstract void TurboBoost();
        
        protected Car() {}

        protected Car(string petName, int currentSpeed, int maxSpeed)
        {
            PetName = petName;
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
        }
    }
}