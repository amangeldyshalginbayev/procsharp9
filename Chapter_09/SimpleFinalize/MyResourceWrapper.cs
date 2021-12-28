using System;

namespace SimpleFinalize
{
    public class MyResourceWrapper
    {
        //protected override void Finalize(){ }
        
        // Clean up unmanaged resources here.
        ~MyResourceWrapper()
        {
            //Console.WriteLine("Cleaning up!");
            Console.Beep();
        }
    }
}