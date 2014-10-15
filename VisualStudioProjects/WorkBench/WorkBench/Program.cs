using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBench
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyEncapsulator myEncap = new StrategyEncapsulator();
            myEncap.StratInterface = new StrategyChild1();
            myEncap.runBehaviour();
            myEncap.StratInterface = new StrategyChild2();
            myEncap.runBehaviour();
            Console.ReadLine();


        }
    }
}
