using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sudoku
{
    public partial class Form1 : Form
    {

        int[,] gridData = new int[9, 9]{
            {1,0,0,0,0,0,0,0,0},
            {0,1,0,0,0,0,0,0,0},
            {0,0,1,0,0,0,0,0,0},
            {0,0,0,1,0,0,0,0,0},
            {0,0,0,0,1,0,0,0,0},
            {0,0,0,0,0,1,0,0,0},
            {0,0,0,0,0,0,1,0,0},
            {0,0,0,0,0,0,0,1,0},
            {0,0,0,0,0,0,0,0,1}


        };

        List<TextBox> textBoxes = new List<TextBox>();
        List<CellInfo> cellAnalyses = new List<CellInfo>();

        public Form1()
        {
            InitializeComponent();
            PopTextBoxList();
            populateGrid(gridData);
        }

        private void populateGrid(int[,] data)
        {

            int textBoxCount = 0;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    textBoxes[textBoxCount].Text = data[x, y].ToString();
                    textBoxCount++;
                }

            }

        }

        private void PopTextBoxList()
        {
            textBoxes.Add(cell1);
            textBoxes.Add(cell2);
            textBoxes.Add(cell3);
            textBoxes.Add(cell4);
            textBoxes.Add(cell5);
            textBoxes.Add(cell6);
            textBoxes.Add(cell7);
            textBoxes.Add(cell8);
            textBoxes.Add(cell9);
            textBoxes.Add(cell10);
            textBoxes.Add(cell11);
            textBoxes.Add(cell12);
            textBoxes.Add(cell13);
            textBoxes.Add(cell14);
            textBoxes.Add(cell15);
            textBoxes.Add(cell16);
            textBoxes.Add(cell17);
            textBoxes.Add(cell18);
            textBoxes.Add(cell19);
            textBoxes.Add(cell20);
            textBoxes.Add(cell21);
            textBoxes.Add(cell22);
            textBoxes.Add(cell23);
            textBoxes.Add(cell24);
            textBoxes.Add(cell25);
            textBoxes.Add(cell26);
            textBoxes.Add(cell27);
            textBoxes.Add(cell28);
            textBoxes.Add(cell29);
            textBoxes.Add(cell30);
            textBoxes.Add(cell31);
            textBoxes.Add(cell32);
            textBoxes.Add(cell33);
            textBoxes.Add(cell34);
            textBoxes.Add(cell35);
            textBoxes.Add(cell36);
            textBoxes.Add(cell37);
            textBoxes.Add(cell38);
            textBoxes.Add(cell39);
            textBoxes.Add(cell40);
            textBoxes.Add(cell41);
            textBoxes.Add(cell42);
            textBoxes.Add(cell43);
            textBoxes.Add(cell44);
            textBoxes.Add(cell45);
            textBoxes.Add(cell46);
            textBoxes.Add(cell47);
            textBoxes.Add(cell48);
            textBoxes.Add(cell49);
            textBoxes.Add(cell50);
            textBoxes.Add(cell51);
            textBoxes.Add(cell52);
            textBoxes.Add(cell53);
            textBoxes.Add(cell54);
            textBoxes.Add(cell55);
            textBoxes.Add(cell56);
            textBoxes.Add(cell57);
            textBoxes.Add(cell58);
            textBoxes.Add(cell59);
            textBoxes.Add(cell60);
            textBoxes.Add(cell61);
            textBoxes.Add(cell62);
            textBoxes.Add(cell63);
            textBoxes.Add(cell64);
            textBoxes.Add(cell65);
            textBoxes.Add(cell66);
            textBoxes.Add(cell67);
            textBoxes.Add(cell68);
            textBoxes.Add(cell69);
            textBoxes.Add(cell70);
            textBoxes.Add(cell71);
            textBoxes.Add(cell72);
            textBoxes.Add(cell73);
            textBoxes.Add(cell74);
            textBoxes.Add(cell75);
            textBoxes.Add(cell76);
            textBoxes.Add(cell77);
            textBoxes.Add(cell78);
            textBoxes.Add(cell79);
            textBoxes.Add(cell80);
            textBoxes.Add(cell81);

        }

        private void loadPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.InitialDirectory = Application.StartupPath + "\\puzzles";
            DialogResult dResult = fileSelect.ShowDialog();

            if (dResult == DialogResult.OK)
            {

                string contents = File.ReadAllText(fileSelect.FileName);
                lblPuzzleName.Text = fileSelect.FileName;
                Debug.WriteLine(contents);
                gridData = JsonConvert.DeserializeObject<int[,]>(contents);
                //JArray desArray = JsonConvert.DeserializeObject<JArray>(contents);
                //int[,] resultArray = desArray.ToObject<int[,]>();
                populateGrid(gridData);


            }

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            cellAnalyses.Clear();

            basicAnalysis();
            advancedAnalysis();

        }

        private void basicAnalysis()
        {
            lblBaseDifficulty.Text = "bleh";
        }

        private void advancedAnalysis()
        {
            lblModDiff.Text = "blah";

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {

                    //Debug.WriteLine("Checking {0},{1} value is {2}", x, y, gridData[x, y]);
                    AnalyseSquare(x, y);

                }
            }


            DrawGraph();








        }

        private void DrawGraph()
        {


            int[] graphData = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (CellInfo cInfo in cellAnalyses)
            {
                //Debug.WriteLine("Cell {0} {1} NumSolutions {2}", cInfo.Cell.X, cInfo.Cell.Y, cInfo.NumSolutions);
                graphData[cInfo.NumSolutions]++;

            }

            Graphics g = pnlGraph.CreateGraphics();
            g.Clear(Color.White);
            Pen graphPen = new Pen(Color.Black, 1);

            for (int i = 0; i < 10; i++)
            {
                //Debug.WriteLine("gdata {0}", graphData[i]);
                g.DrawRectangle(graphPen, new Rectangle(10 + (30 * i), pnlGraph.Height - 10 - (graphData[i] * 5), 30, graphData[i] * 5));

            }

            int difficultyRating = 0;
            for (int i = 0; i < 10; i++)
            {
                difficultyRating += i * graphData[i];
            }
            lblDifficulty.Text = difficultyRating.ToString();


        }

        private void AnalyseSquare(int row, int col)
        {



            if (gridData[row, col] > 0)
            {
                cellAnalyses.Add(new CellInfo(new Point(row, col)));
            }
            else
            {

                List<int> arrSolutions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


                //check the row

                for (int y = 0; y < 9; y++)
                {
                    //Debug.WriteLine("analysing {0} {1}", row, y);

                    if (gridData[row, y] > 0 && arrSolutions.Contains(gridData[row, y]))
                    {
                        arrSolutions.Remove(gridData[row, y]);
                    }

                }

                //check the column

                for (int x = 0; x < 9; x++)
                {


                    if (gridData[x, col] > 0 && arrSolutions.Contains(gridData[x, col]))
                    {
                        arrSolutions.Remove(gridData[x, col]);
                    }

                }

                //check the sector

                int sectorStartRow = (row / 3) * 3;
                int sectorStartCol = (col / 3) * 3;
                //Debug.WriteLine("sectorStartRow {0}", sectorStartRow);

                for (int x = sectorStartRow; x < (sectorStartRow + 3); x++)
                {
                    for (int y = sectorStartCol; y < (sectorStartCol + 3); y++)
                    {
                        if (gridData[x, y] > 0 && arrSolutions.Contains(gridData[x, y]))
                        {
                            arrSolutions.Remove(gridData[x, y]);
                        }
                    }
                }




                cellAnalyses.Add(new CellInfo(new Point(row, col), arrSolutions));







            }













        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            //check for single solutions
            
            do{
                foreach (CellInfo cInfo in cellAnalyses)
                {
                    if (cInfo.NumSolutions == 1)
                    {
                        gridData[cInfo.Cell.X, cInfo.Cell.Y] = cInfo.Solutions[0];
                        populateGrid(gridData);
                        
                    }



                }
                cellAnalyses.Clear();
                advancedAnalysis();

                

            }while(cellAnalyses.Where(ci => ci.NumSolutions == 1).Count() > 0);


            //generate population
            Random RN = new Random();
            List<List<int>> population = new List<List<int>>();
            for (int i = 0; i < 6; i++){
                List<int> chromosome = new List<int>();
                foreach(CellInfo cInfo in cellAnalyses.Where(ci => ci.NumSolutions > 1)){

                    
                    int pick = RN.Next(0, cInfo.NumSolutions);
                    chromosome.Add(cInfo.Solutions[pick]);
                }
                population.Add(chromosome);
            }

            foreach (List<int> chromo in population)
            {
                foreach (int i in chromo)
                {
                    Debug.Write(i);
                }
                Debug.WriteLine("");
            }
            
        }

        private int checkErrors()
        {
            int numErrors = 0;

            return numErrors;
        }

        private void AssessFitness(List<List<int>> pop)
        {

            foreach(List<int> chromo in pop){
                int[,] assessGrid = gridData;

                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (assessGrid[x, y] == 0)
                        {
                            assessGrid[x,y] = chromo[0];
                            chromo.RemoveAt(0);
                        }
                    }
                }




            }
        }

    }
}
