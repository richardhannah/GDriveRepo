using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerpatter
{
    class Subject : IMyObservable
    {

        public void RegisterObserver();
        public void RemoveObserver();
        public void NotifyObservers();



    }
}
