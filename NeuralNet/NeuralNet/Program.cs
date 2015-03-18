using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    class Program
    {
        static void Main(string[] args)
        {

            Perceptron perceptron = new Perceptron(2);

            perceptron.InputList.Add(new WeightedInput<int>(1));
            Console.WriteLine(perceptron.InputList[0].Weight);

            while (true)
            {
                Console.WriteLine("input value");
                perceptron.InputList[0].Weight = Convert.ToInt32(Console.ReadLine());
                perceptron.EvaluateInput();

            }





        }
    }
}
