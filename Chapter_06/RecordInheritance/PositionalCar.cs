namespace RecordInheritance
{
    public record PositionalCar(string Make, string Model, string Color);
    public record PositionalMinivan(string Make, string Model, string Color, int Seats) : PositionalCar(Make, Model, Color);

    public record MotorCycle(string Make, string Model);
    public record Scooter(string Make, string Model) : MotorCycle(Make, Model);


}