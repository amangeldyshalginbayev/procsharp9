using System;

namespace CustomInterfaces
{
    public abstract class Shape
    {
        public string PetName { get; set; }

        protected Shape(string petName = "NoName")
        {
            PetName = petName;
            Console.WriteLine("Shape(string petName = 'NoName') called.");
        }
        
        protected Shape()
        {
            Console.WriteLine("Shape() called.");
        }

        public abstract void Draw();
        // {
        //     Console.WriteLine("Inside Shape.Draw()");
        // }
    }
}