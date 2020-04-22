using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    abstract class RadiationMonitor : IObserver
    {

        public RadiationMonitor(string location)
        {

        }

        abstract public void Update(IObservable subject, Object o);

        public string GetLocation()
        {
            return null;
        }

        public abstract string GenerateReport(double observation);
        
        public string Now()
        {
            // The current time in yyyy-MM-dd HH:mm:ss format
            return null;
        }
    }
}
