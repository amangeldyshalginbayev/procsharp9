using System;

namespace FinalizableDisposableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Dispose() / Destructor Combo Platter *****");
            
            // Call Dispose() manually, this will not call the finalizer
            ResourceWrapper rw = new ResourceWrapper();
            rw.Dispose();
            
            // Do not call Dispose(). This will trigger the finalizer when the object gets GCd
            ResourceWrapper rw2 = new ResourceWrapper();
        }
    }
}