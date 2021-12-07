using System;

namespace SimpleClassExample
{
    public class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        
        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeeeeee Haaaaaaaeewww!");
        }

        public Motorcycle(int intensity) : this(intensity,"")
        {
            Console.WriteLine("In ctor taking an int");
            // if (intensity > 10)
            // {
            //     intensity = 10;
            // }
            //
            // driverIntensity = intensity;
        }

        public Motorcycle(string name) : this(0,name)
        {
            Console.WriteLine("In ctor taking a string");
        }

        // public Motorcycle(int intensity, string name)
        // {
        //     Console.WriteLine("In master ctor");
        //     // if (intensity > 10)
        //     // {
        //     //     intensity = 10;
        //     // }
        //
        //     if (intensity > 10)
        //     {
        //         intensity = 10;
        //     }
        //     driverIntensity = intensity;
        //     driverName = name;
        // }

        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            driverName = name;
        }

        public Motorcycle()
        {
            Console.WriteLine("In default ctor");
        }

        public void SetDriverName(string name) => driverName = name;

        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
        }

    }
}