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

            Perceptron perceptron = new Perceptron(2.0);

            while (true)
            {
                Console.WriteLine("input value");
                perceptron.Input = Convert.ToDouble(Console.ReadLine());

            }





        }
    }
}
