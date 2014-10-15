using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBench
{
    class StrategyEncapsulator
    {
        private IStrategyPattern stratInterface;

        public IStrategyPattern StratInterface
        {
            set {stratInterface = value ;}
        }

        public void runBehaviour()
        {
            stratInterface.Behaviour();

        }

    }
}
