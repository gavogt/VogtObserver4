using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    class RadiationSensor : IObservable
    {
        private List<IObserver> _observers;
        private double _radiation;

        public RadiationSensor(string location, int seed)
        {

        }

        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                //observer.Update();
            }
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public string GetLocation()
        {
            return null;
        }

        public void ReadRadiation()
        {
            // Updates radiation, changes the state to true, and notifies all observers of the change

        }

        // set a private radiation variable to a random double between 0 and 10
        public double GetRadiation()
        {
            double temp = 0.0;

            return temp;
        }
    }
}
