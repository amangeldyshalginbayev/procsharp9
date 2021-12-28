using System;

namespace SimpleDispose
{
    public class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            // Clean up logic here
            Console.WriteLine("Dispose() cleaning up unmanaged resources!");
        }
    }
}