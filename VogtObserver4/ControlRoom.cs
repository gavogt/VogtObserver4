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
            if (_warningThreshold < observation)
            {
                return Convert.ToString(observation);
            }
            else
            {
                return null;
            }
        }

        public override void Update(IObservable subject, Object state)
        {
            if (GenerateReport(Convert.ToDouble(state.ToString())) != null)
            {
                Console.WriteLine($"{DateTime.Now}::WARNING::{GenerateReport(Convert.ToDouble(state.ToString()))}::{_location}");
            }
        }
    }
}
