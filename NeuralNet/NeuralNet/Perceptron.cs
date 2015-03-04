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


        public double Input
        {
            set
            {
                input = value;
                EvaluateInput(input);
            }
        }

        public Perceptron(double cThreshold)
        {
            threshold = cThreshold;

        }

        private void EvaluateInput(double cInput){

            if (cInput >= threshold)
            {
                Console.WriteLine("Neuron Fires");
            }
            else
            {
                Console.WriteLine("Neuron Inactive");
            }


        }


    }
}
