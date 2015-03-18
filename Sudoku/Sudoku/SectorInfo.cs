using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sudoku
{
    class SectorInfo
    {

        public Point StartPoint
        {
            get;
            set;
        }

        public int SectorId
        {
            get;
            set;
        }

        public int GivensInSector
        {
            get;
            set;
        }


        public SectorInfo(int cSectorId,int cStartRow, int cStartCol)
        {
            Point startPoint = new Point(cStartCol, cStartRow);
            StartPoint = startPoint;
            SectorId = cSectorId;
            GivensInSector = 0;
        }

    }
}
