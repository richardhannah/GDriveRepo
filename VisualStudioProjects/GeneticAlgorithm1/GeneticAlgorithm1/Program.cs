using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using NCalc;


namespace GeneticAlgorithm1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> decoderDict = new Dictionary<string, string>();
            decoderDict.Add("0000", "0");
            decoderDict.Add("0001", "1");
            decoderDict.Add("0010", "2");
            decoderDict.Add("0011", "3");
            decoderDict.Add("0100", "4");
            decoderDict.Add("0101", "5");
            decoderDict.Add("0110", "6");
            decoderDict.Add("0111", "7");
            decoderDict.Add("1000", "8");
            decoderDict.Add("1001", "9");
            decoderDict.Add("1010", "+");
            decoderDict.Add("1011", "-");
            decoderDict.Add("1100", "/");
            decoderDict.Add("1101", "na");
            decoderDict.Add("1110", "na");
            decoderDict.Add("1111", "na");


            Dictionary<int, string> hexDecoder = new Dictionary<string, string>();
            decoderDict.Add(0x0, "0");
            decoderDict.Add("0001", "1");
            decoderDict.Add("0010", "2");
            decoderDict.Add("0011", "3");
            decoderDict.Add("0100", "4");
            decoderDict.Add("0101", "5");
            decoderDict.Add("0110", "6");
            decoderDict.Add("0111", "7");
            decoderDict.Add("1000", "8");
            decoderDict.Add("1001", "9");
            decoderDict.Add("1010", "+");
            decoderDict.Add("1011", "-");
            decoderDict.Add("1100", "/");
            decoderDict.Add("1101", "na");
            decoderDict.Add("1110", "na");
            decoderDict.Add("1111", "na");

            //generate random bit sequence

            BitArray bitArray = new BitArray(16);
            RFHRandom RNG = new RFHRandom();
            

            for (int i = 0; i < bitArray.Length; i++)
                {
                    
                    bitArray[i] = RNG.NextBoolean();
                    Console.Write(bitArray[i] ? 1 : 0);
                }

            Console.WriteLine();

            string decodeResult = null;

            for (int i = 0; i < bitArray.Length; i = i + 4)
            {
                string tempArr =null;
                for (int j = 0; j < 4; j++)
                {
                    int index = i + j;
                    tempArr += (bitArray[index] ? 1:0);
                }
                decodeResult = decodeResult + decoderDict[tempArr];
          
            }

            Console.WriteLine(decodeResult);

            Expression e = new Expression(decodeResult);

            try
            {
                object result = e.Evaluate();
                Console.WriteLine("=" + result.ToString());
            }
            catch
            {
                Console.WriteLine("invalid expression");
            }
           


            


            
           
            
            Console.WriteLine();

                Console.ReadLine();



        }
    }
}
