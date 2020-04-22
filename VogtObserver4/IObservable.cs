using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    interface IObservable
    {
        public void AddObserver(IObserver o);

        public void RemoveObserver(IObserver o);

        public void Notify();
    }
}
