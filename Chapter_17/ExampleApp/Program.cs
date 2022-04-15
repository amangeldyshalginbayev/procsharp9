using System;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("CarLibrary.SportsCar", false,true);

            Type externalType = Type.GetType("CarLibrary.SportsCar, CarLibrary");


        }
    }
}