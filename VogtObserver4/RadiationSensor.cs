using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    class RadiationSensor : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private double _radiation;
        private string _location;
        private int _seed;
        private double _state;

        public RadiationSensor(string location, int seed)
        {
            _location = location;
            _seed = seed;
        }

        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void Notify(Object state)
        {
            foreach (var observer in _observers)
            {
                observer.Update(this, state);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public string GetLocation()
        {
            return _location;
        }

        public void ReadRadiation()
        // set state
        {

            Notify(GetRadiation());
            // Updates radiation, changes the state to true, and notifies all observers of the change

        }

        // set a private radiation variable to a random double between 0 and 10
        // get state
        public double GetRadiation()
        {
            Random random = new Random();
            _state = random.Next(1, _seed);

            return _state;
        }
    }
}
