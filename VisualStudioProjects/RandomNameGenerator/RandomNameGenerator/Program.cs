using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RFHGdriveLib;


namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            NameGenerator nameGen = new NameGenerator();
            

            string name1 = nameGen.getFname();
            string name2 = nameGen.getMname();
            string name3 = nameGen.getName();
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.ReadLine();
            

        }
    }
}
