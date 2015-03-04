namespace OCR
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
            this.pnlDrawArea = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImgX = new System.Windows.Forms.Label();
            this.lblImgY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDrawArea
            // 
            this.pnlDrawArea.BackColor = System.Drawing.Color.White;
            this.pnlDrawArea.Location = new System.Drawing.Point(138, 82);
            this.pnlDrawArea.Name = "pnlDrawArea";
            this.pnlDrawArea.Size = new System.Drawing.Size(207, 198);
            this.pnlDrawArea.TabIndex = 0;
            this.pnlDrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawArea_MouseDown);
            this.pnlDrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawArea_MouseMove);
            this.pnlDrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawArea_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(24, 158);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyse.TabIndex = 2;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // txtResolution
            // 
            this.txtResolution.Location = new System.Drawing.Point(244, 27);
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(100, 20);
            this.txtResolution.TabIndex = 3;
            this.txtResolution.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "resolution";
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.White;
            this.pnlDisplay.Location = new System.Drawing.Point(440, 82);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(226, 198);
            this.pnlDisplay.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // lblImgX
            // 
            this.lblImgX.AutoSize = true;
            this.lblImgX.Location = new System.Drawing.Point(185, 300);
            this.lblImgX.Name = "lblImgX";
            this.lblImgX.Size = new System.Drawing.Size(0, 13);
            this.lblImgX.TabIndex = 8;
            // 
            // lblImgY
            // 
            this.lblImgY.AutoSize = true;
            this.lblImgY.Location = new System.Drawing.Point(185, 327);
            this.lblImgY.Name = "lblImgY";
            this.lblImgY.Size = new System.Drawing.Size(0, 13);
            this.lblImgY.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 538);
            this.Controls.Add(this.lblImgY);
            this.Controls.Add(this.lblImgX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResolution);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlDrawArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawArea;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImgX;
        private System.Windows.Forms.Label lblImgY;
    }
}

