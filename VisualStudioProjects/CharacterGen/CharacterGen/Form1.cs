using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RFHGdriveLib;

namespace CharacterGen
{
    public partial class Form1 : Form
    {
        Character newChar;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnGenChar_Click(object sender, EventArgs e)
        {

            newChar = new Character();
            txtCharName.Text = newChar.CharName;
            txtTier.Text = newChar.Tier.ToString();
            txtLevel.Text = newChar.Level.ToString();
            txtSpecialty.Text = newChar.T1Skill.ToString();
            txtBonus.Text = newChar.T1SkillBonus.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            newChar.levelUp();
            txtLevel.Text = newChar.Level.ToString();
            txtBonus.Text = newChar.T1SkillBonus.ToString();
        }
    }
}
