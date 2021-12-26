using System;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            Octagon oct = new Octagon();
            
            // ((IDrawToPrinter)oct).Draw();
            //
            // if (oct is IDrawToMemory dtm)
            // {
            //     dtm.Draw();
            // }
            
            IDrawToForm itForm = (IDrawToForm)oct;
            itForm.Draw();

            if (oct is IDrawToMemory dtm)
            {
                dtm.Draw();
            }

            Console.ReadLine();
        }
    }
}