using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    class ResearchCenter : RadiationMonitor
    {
        private string _location;
        private double _average;
        private int _count = 1;
        public ResearchCenter(string location) : base(location)
        {
            _location = location;
        }

        public override string GenerateReport(double observation)
        {
            _count++;
            _average += observation;
            _average = _average / _count;

            return Convert.ToString(_average);
        }

        public override void Update(IObservable subject, Object o)
        {
            
            Console.WriteLine($"{DateTime.Now}::moving average::{GenerateReport(Convert.ToDouble(o))}::for {_location}");
        }

    }
}
