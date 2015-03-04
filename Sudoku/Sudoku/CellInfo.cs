using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sudoku
{
    class CellInfo
    {

        public Point Cell
        {
            get;
            set;
        }

        public List<int> Solutions
        {
            get;
            set;
        }

        public int NumSolutions
        {
            get {

                if (Solutions != null)
                {
                    return Solutions.Count();
                }
                else
                {
                    return 0;
                }
            }
        }

        public CellInfo(Point coordinates, List<int> solutionArray = null)
        {
            Cell = coordinates;
            Solutions = solutionArray;


        }

    }
}
