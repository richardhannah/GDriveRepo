using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkBench
{
    public class StrategyChild1 : StrategyBase, IStrategyPattern
    {
        public override void Display()
        {
            Console.WriteLine("This is child 1");
        }

        public void Behaviour()
        {
            Console.WriteLine("Child 1 behaviour");
        }
    }
}
