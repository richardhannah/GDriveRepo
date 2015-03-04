using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR
{
    public partial class Form1 : Form
    {

        Graphics gfx;
        Pen pen = new Pen(new SolidBrush(Color.Black),8);
        
        bool drawing = false;

        List<Point> drawHistory = new List<Point>();

        Bitmap testBmp;
        int resolution;

        public Form1()
        {
            InitializeComponent();
            resolution = Convert.ToInt32(txtResolution.Text);
            testBmp = new Bitmap(pnlDrawArea.Width, pnlDrawArea.Height);
            
        }

        private void pnlDrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            
            
            if(e.Button == MouseButtons.Left){
                drawing = true;
            }
        }

        private void pnlDrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            
        }

        private void pnlDrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics tempgfx = pnlDrawArea.CreateGraphics();
                gfx = Graphics.FromImage(testBmp);

                drawHistory.Add(new Point(e.X, e.Y));

                tempgfx.FillEllipse(new SolidBrush(Color.Black),new Rectangle(e.X,e.Y,8,8));
                gfx.FillEllipse(new SolidBrush(Color.Black), new Rectangle(e.X, e.Y, 8, 8));
                
            }
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlDrawArea.Invalidate();
            pnlDisplay.Invalidate();

            drawHistory.Clear();
            testBmp = new Bitmap(pnlDrawArea.Width, pnlDrawArea.Height);
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            //Bitmap bitMap = new Bitmap(pnlDrawArea.Width,pnlDrawArea.Height);

            resolution = Convert.ToInt32(txtResolution.Text);

            foreach (Point pnt in drawHistory)
            {
                Debug.WriteLine("X :{0}  Y : {1}", pnt.X.ToString(), pnt.Y.ToString());
            }

            int minX = drawHistory.Where(p=>p.X >=0).Min(p => p.X);
            int minY = drawHistory.Where(p => p.Y >= 0).Min(p => p.Y);

            //these still need fixed so program doesnt crash if drawing goes out of bounds
            int maxX = drawHistory.Max(p => p.X) + 8;
            int maxY = drawHistory.Max(p => p.Y) + 8;

            
            maxX = maxX + (resolution - ((maxX-minX) % resolution));
            maxY = maxY + (resolution - ((maxY-minY) % resolution));

            /*
            if (maxX > pnlDrawArea.Width)
            {
                maxX = pnlDrawArea.Width;
                minX = minX -(resolution - ((maxX-minX) % resolution));
            }

            if (maxY > pnlDrawArea.Height)
            {
                maxY = pnlDrawArea.Height;
                minY = minY - (resolution - ((maxY - minY) % resolution));
            }
            */
            Graphics g = pnlDrawArea.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Black,1), minX, minY, (maxX - minX), (maxY - minY));
            
            testBmp = cropImage(testBmp,new Rectangle(minX,minY,(maxX - minX),(maxY-minY)));
            testBmp.Save("test.bmp");

            lblImgX.Text = testBmp.Width.ToString();
            lblImgY.Text = testBmp.Height.ToString();

            
            List<ImageFragment> chopped = new List<ImageFragment>();
            
            int fragmentSizeX = testBmp.Width / resolution;
            int fragmentSizeY = testBmp.Height / resolution;

            //Debug.WriteLine(fragmentSize);
            Debug.WriteLine("X: {0} Y:{1}", testBmp.Width,testBmp.Height);

            for (int x = 0; x < testBmp.Width; x = x + fragmentSizeX)
            {
                for (int y = 0; y < testBmp.Height; y = y + fragmentSizeY)
                {
                    if ((testBmp.Height - y) > fragmentSizeY)
                    {
                        chopped.Add(new ImageFragment(cropImage(testBmp, new Rectangle(x, y, fragmentSizeX, fragmentSizeY)), new Point(x, y)));
                    }
                    else
                    {
                        int yHeight = testBmp.Height - y;
                        chopped.Add(new ImageFragment(cropImage(testBmp, new Rectangle(x, y, fragmentSizeX, yHeight)), new Point(x, y)));
                    }

                }
            }

            Graphics gDisp = pnlDisplay.CreateGraphics();
            
            foreach (ImageFragment frag in chopped)
            {
                
                gDisp.DrawImage(frag.ImageFrag, new Point(frag.Coords.X,frag.Coords.Y));
                gDisp.DrawRectangle(new Pen(Color.Red, 1), frag.Coords.X, frag.Coords.Y, frag.ImageFrag.Width, frag.ImageFrag.Height);
            }
            
            

        }

        private Bitmap cropImage(Bitmap img, Rectangle cropArea)
        {
            //Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = img.Clone(cropArea, img.PixelFormat);
            return bmpCrop;
        }
    }
}
