using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm1
{
    class RFHRandom : Random
    {

        public bool NextBoolean()
        {
            return Next() % 2 == 0 ? true : false;
        }



    }
}
