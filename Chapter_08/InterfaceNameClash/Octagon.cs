using System;

namespace InterfaceNameClash
{
    public class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing Octagon to form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing Octagon to memory...");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing Octagon to a printer...");
        }
    }
}