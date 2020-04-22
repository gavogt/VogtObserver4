using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    interface IObservable
    {
        public void AddObserver();

        public void RemoveObserver();

        public void Notify();
    }
}
