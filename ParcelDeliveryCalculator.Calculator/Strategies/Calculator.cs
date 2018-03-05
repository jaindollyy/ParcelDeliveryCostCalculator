
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace ParcelDeliveryCalculator
{
    /// <summary>
    /// The function to calculate the cost receives weight or volume value, 
    /// and an object that is one of the concrete strategy classes.
    /// </summary>
    public class Calculator : System.IDisposable
    {
        public int Calculate(int weight_volume, IParcelCost parcelCost)
        {
            return parcelCost.Calculate(weight_volume);
        }

        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Instantiate a SafeHandle instance.
       SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);

            // Suppress finalization.
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
            }

            // Free any unmanaged objects here.            
            disposed = true;
        }

        //Base class
        ~Calculator()
        {
            Dispose(false);
        }
    }
}
