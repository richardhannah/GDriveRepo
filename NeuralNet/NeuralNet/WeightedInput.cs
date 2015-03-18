using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class WeightedInput<T> : IObservable<T>
    {


        public T Weight { get; set; }

        public T InputVal { get; set; }

        public WeightedInput(T cWeight)
        {
            Weight = cWeight;
        }





        public IDisposable Subscribe(IObserver<T> observer)
        {
            throw new NotImplementedException();
        }
    }
}
