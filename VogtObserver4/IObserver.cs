using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver4
{
    interface IObserver
    {
        public void Update(IObservable subject, Object o);
    }
}
