using System;

namespace FinalizableDisposableClass
{
    public class ResourceWrapper : IDisposable
    {
        // Used to determine if Dispose() already called
        private bool _disposed = false;
        
        public void Dispose()
        {
            // parameter "true" means that object user triggered clean up
            CleanUp(true);
            
            GC.SuppressFinalize(this);
        }

        ~ResourceWrapper()
        {
            // parameter "false" means that GC triggered clean up
            CleanUp(false);
        }

        private void CleanUp(bool disposing)
        {
            // safe in case this method called several times
            if (!_disposed)
            {
                if (disposing)
                {
                    // Disposed managed resources here
                }
                // Clean up unmanaged resources here
            }

            _disposed = true;
        }
    }
}