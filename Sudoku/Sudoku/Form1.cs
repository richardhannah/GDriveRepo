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

        public Form1()
        {
            InitializeComponent();

            PopTextBoxList();
            populateGrid(gridData);
        }

        private void populateGrid(int[,] data){

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
                int[,] resultArray = JsonConvert.DeserializeObject<int[,]>(contents);
                //JArray desArray = JsonConvert.DeserializeObject<JArray>(contents);
                //int[,] resultArray = desArray.ToObject<int[,]>();
                populateGrid(resultArray);

                
            }
            
        }  

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
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
        }

    }
}
