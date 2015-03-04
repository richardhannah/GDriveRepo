using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OCR
{
    class ImageFragment
    {

        //private Bitmap imageFrag;
        //private Point coords;

        public Bitmap ImageFrag
        {
            get;
            set;
        }

        public Point Coords
        {
            get;
            set;
        }

        public ImageFragment(Bitmap cImg, Point cPnt){

            ImageFrag = cImg;
            Coords = cPnt;

        }


    }
}
