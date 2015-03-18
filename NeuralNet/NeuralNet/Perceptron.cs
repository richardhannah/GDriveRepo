using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{

    

    class Perceptron
    {

       

        private double threshold;
        private double input;


        public List<WeightedInput<int>> InputList { get; set; }

        

        public Perceptron(double cThreshold)
        {
            threshold = cThreshold;
            InputList = new List<WeightedInput<int>>();
            Console.WriteLine("perceptron created threshold is {0}", threshold);

        }

        public void EvaluateInput(){

            int sumOfInputs = 0;

            foreach(WeightedInput<int> wInput in InputList){

                sumOfInputs += wInput.InputVal + wInput.Weight;
                Console.WriteLine("Running total = {0}", sumOfInputs);

            }

            Console.WriteLine("total sum of inputs {0}", sumOfInputs);
            if (sumOfInputs > threshold)
            {
                Console.WriteLine("neuron fires");
            }
            else
            {
                Console.WriteLine("neuron not fired");
            }
        }


    }
}
