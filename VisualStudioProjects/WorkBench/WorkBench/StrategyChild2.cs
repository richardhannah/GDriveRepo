using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkBench
{
    public class StrategyChild2 : StrategyBase, IStrategyPattern
    {
        public override void Display()
        {
            Console.WriteLine("This is child 2");
        }

        public void Behaviour()
        {
            Console.WriteLine("Child 2 behaviour");
        }
    }
}
