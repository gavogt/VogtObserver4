using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    abstract class RadiationMonitor : IObserver
    {
        private string _location;

        public RadiationMonitor(string location)
        {
            _location = location;
        }

        abstract public void Update(IObservable subject, Object o);

        public string GetLocation()
        {
            return _location;
        }

        public abstract string GenerateReport(double observation);

    }
}
