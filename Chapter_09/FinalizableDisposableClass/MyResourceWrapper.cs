using System;

namespace FinalizableDisposableClass
{
    public class MyResourceWrapper : IDisposable
    {
        // The garbage collector will call this method if the object user forgets to call Dispose().
        ~MyResourceWrapper()
        {
            // Clean up internal unmanaged resources here yourself(unmanaged means unmanaged by .NET runtime)
            // Do not call Dispose() on any managed objects (managed means managed by .NET runtime), this done by GC
            Console.WriteLine("Inside ~MyResourceWrapper() called by GC.");
        }

        // The object user calls this method to clean up resources asap
        public void Dispose()
        {
            // Clean up any unmanaged resource here yourself
            // Call Dispose() on other contained disposable objects here
            // No need to finalize if user called Dispose(), so suppress finalization
            GC.SuppressFinalize(this);
            throw new NotImplementedException();
        }
    }
}