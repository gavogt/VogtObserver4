using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    class ResearchCenter : RadiationMonitor
    {
        private string _location;

        public ResearchCenter(string location) : base(location)
        {
            _location = location;
        }

        public override string GenerateReport(double observation)
        {
            throw new NotImplementedException();
        }

        public override void Update(IObservable subject, Object o)
        {
            Console.WriteLine($"{DateTime.Now}::moving average::::for Nuclear Research");
        }

    }
}
