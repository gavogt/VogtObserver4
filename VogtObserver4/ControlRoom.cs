using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    class ControlRoom : RadiationMonitor
    {
        private double _warningThreshold;
        private string _location;

        public ControlRoom(string location, double warningThreshold):base(location)
        {
            _location = location;
            _warningThreshold = warningThreshold;
        }

        public override string GenerateReport(double observation)
        {
            throw new NotImplementedException();
        }

        public override void Update(IObservable subject, Object o)
        {
            Console.WriteLine($"{DateTime.Now}::WARNING::::Reactor A Control Room");
        }
    }
}
