using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerpatter
{
    interface IMyObservable
    {
        void RegisterObserver();
        void RemoveObserver();
        void NotifyObservers();
    }
}
