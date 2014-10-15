namespace CharacterGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenChar = new System.Windows.Forms.Button();
            this.txtCharName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCharName = new System.Windows.Forms.Label();
            this.lblTier = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtTier = new System.Windows.Forms.TextBox();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenChar
            // 
            this.btnGenChar.Location = new System.Drawing.Point(397, 72);
            this.btnGenChar.Name = "btnGenChar";
            this.btnGenChar.Size = new System.Drawing.Size(75, 23);
            this.btnGenChar.TabIndex = 0;
            this.btnGenChar.Text = "Generate";
            this.btnGenChar.UseVisualStyleBackColor = true;
            this.btnGenChar.Click += new System.EventHandler(this.btnGenChar_Click);
            // 
            // txtCharName
            // 
            this.txtCharName.Location = new System.Drawing.Point(163, 75);
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(100, 20);
            this.txtCharName.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(492, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(23, 77);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(35, 13);
            this.lblCharName.TabIndex = 4;
            this.lblCharName.Text = "Name";
            // 
            // lblTier
            // 
            this.lblTier.AutoSize = true;
            this.lblTier.Location = new System.Drawing.Point(23, 113);
            this.lblTier.Name = "lblTier";
            this.lblTier.Size = new System.Drawing.Size(25, 13);
            this.lblTier.TabIndex = 5;
            this.lblTier.Text = "Tier";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(25, 146);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Level";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(25, 179);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(50, 13);
            this.lblSpecialty.TabIndex = 7;
            this.lblSpecialty.Text = "Specialty";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(25, 213);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(37, 13);
            this.lblBonus.TabIndex = 8;
            this.lblBonus.Text = "Bonus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(163, 210);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 10;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(163, 176);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(100, 20);
            this.txtSpecialty.TabIndex = 11;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(163, 146);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 12;
            // 
            // txtTier
            // 
            this.txtTier.Location = new System.Drawing.Point(163, 113);
            this.txtTier.Name = "txtTier";
            this.txtTier.Size = new System.Drawing.Size(100, 20);
            this.txtTier.TabIndex = 13;
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Location = new System.Drawing.Point(397, 131);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(75, 23);
            this.btnLevelUp.TabIndex = 14;
            this.btnLevelUp.Text = "Level Up";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 404);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.txtTier);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblTier);
            this.Controls.Add(this.lblCharName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCharName);
            this.Controls.Add(this.btnGenChar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenChar;
        private System.Windows.Forms.TextBox txtCharName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.Label lblTier;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtTier;
        private System.Windows.Forms.Button btnLevelUp;
    }
}

