using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public abstract class Neuron<T> : IObserver<T>
    {

        private T threshold;

        public List<WeightedInput<T>> Inputs{get;set;}
        

        public Neuron(T cThreshold) {

            threshold = cThreshold;
            Inputs = new List<WeightedInput<T>>();
        
        
        }

        public void OnCompleted(){}


        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(T value)
        {
            throw new NotImplementedException();
        }
    }
}
