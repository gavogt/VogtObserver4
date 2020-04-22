using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    class ControlRoom : RadiationMonitor
    {
        private double _warningThreshold;
        private string _location;
        private Object _state;
        private double _average;

        public ControlRoom(string location, double warningThreshold) : base(location)
        {
            _location = location;
            _warningThreshold = warningThreshold;
        }

        public override string GenerateReport(double observation)
        {
            _average += observation;

            return Convert.ToString(_average);
        }

        public override void Update(IObservable subject, Object state)
        {
            GenerateReport(Convert.ToDouble(state.ToString()));
            Console.WriteLine($"{DateTime.Now}::WARNING::{state.ToString()}::{_location}");
        }
    }
}
