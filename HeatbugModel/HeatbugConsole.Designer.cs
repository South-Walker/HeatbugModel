namespace HeatbugModel
{
    partial class HeatbugConsole
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
            this.btStart = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.gbWorldParm = new System.Windows.Forms.GroupBox();
            this.tbScale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWorldHeght = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWorldWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDisplayFrequency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tbIdealTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumBugs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBugParm = new System.Windows.Forms.GroupBox();
            this.tbBugsPath = new System.Windows.Forms.TextBox();
            this.btFromFile = new System.Windows.Forms.Button();
            this.btRandom = new System.Windows.Forms.Button();
            this.gbWorldParm.SuspendLayout();
            this.gbBugParm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(47, 69);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(47, 98);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(47, 127);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // gbWorldParm
            // 
            this.gbWorldParm.Controls.Add(this.tbScale);
            this.gbWorldParm.Controls.Add(this.label6);
            this.gbWorldParm.Controls.Add(this.tbWorldHeght);
            this.gbWorldParm.Controls.Add(this.label5);
            this.gbWorldParm.Controls.Add(this.tbWorldWidth);
            this.gbWorldParm.Controls.Add(this.label4);
            this.gbWorldParm.Controls.Add(this.tbDisplayFrequency);
            this.gbWorldParm.Controls.Add(this.label1);
            this.gbWorldParm.Location = new System.Drawing.Point(144, 11);
            this.gbWorldParm.Name = "gbWorldParm";
            this.gbWorldParm.Size = new System.Drawing.Size(302, 175);
            this.gbWorldParm.TabIndex = 5;
            this.gbWorldParm.TabStop = false;
            this.gbWorldParm.Text = "World Parm ";
            // 
            // tbScale
            // 
            this.tbScale.Location = new System.Drawing.Point(181, 76);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(100, 25);
            this.tbScale.TabIndex = 13;
            this.tbScale.Text = "1";
            this.tbScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "scale";
            // 
            // tbWorldHeght
            // 
            this.tbWorldHeght.Location = new System.Drawing.Point(181, 138);
            this.tbWorldHeght.Name = "tbWorldHeght";
            this.tbWorldHeght.Size = new System.Drawing.Size(100, 25);
            this.tbWorldHeght.TabIndex = 9;
            this.tbWorldHeght.Text = "1333";
            this.tbWorldHeght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "worldHeight";
            // 
            // tbWorldWidth
            // 
            this.tbWorldWidth.Location = new System.Drawing.Point(181, 107);
            this.tbWorldWidth.Name = "tbWorldWidth";
            this.tbWorldWidth.Size = new System.Drawing.Size(100, 25);
            this.tbWorldWidth.TabIndex = 7;
            this.tbWorldWidth.Text = "2000";
            this.tbWorldWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "worldWidth";
            // 
            // tbDisplayFrequency
            // 
            this.tbDisplayFrequency.Location = new System.Drawing.Point(181, 45);
            this.tbDisplayFrequency.Name = "tbDisplayFrequency";
            this.tbDisplayFrequency.Size = new System.Drawing.Size(100, 25);
            this.tbDisplayFrequency.TabIndex = 1;
            this.tbDisplayFrequency.Text = "1";
            this.tbDisplayFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "displayFrequency";
            // 
            // tbIdealTemp
            // 
            this.tbIdealTemp.Location = new System.Drawing.Point(158, 41);
            this.tbIdealTemp.Name = "tbIdealTemp";
            this.tbIdealTemp.Size = new System.Drawing.Size(100, 25);
            this.tbIdealTemp.TabIndex = 15;
            this.tbIdealTemp.Text = "1";
            this.tbIdealTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "idealTemp";
            // 
            // tbNumBugs
            // 
            this.tbNumBugs.Location = new System.Drawing.Point(398, 41);
            this.tbNumBugs.Name = "tbNumBugs";
            this.tbNumBugs.Size = new System.Drawing.Size(100, 25);
            this.tbNumBugs.TabIndex = 13;
            this.tbNumBugs.Text = "100";
            this.tbNumBugs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "numBugs";
            // 
            // gbBugParm
            // 
            this.gbBugParm.Controls.Add(this.tbBugsPath);
            this.gbBugParm.Controls.Add(this.btFromFile);
            this.gbBugParm.Controls.Add(this.btRandom);
            this.gbBugParm.Controls.Add(this.label2);
            this.gbBugParm.Controls.Add(this.tbIdealTemp);
            this.gbBugParm.Controls.Add(this.tbNumBugs);
            this.gbBugParm.Controls.Add(this.label3);
            this.gbBugParm.Location = new System.Drawing.Point(468, 12);
            this.gbBugParm.Name = "gbBugParm";
            this.gbBugParm.Size = new System.Drawing.Size(605, 174);
            this.gbBugParm.TabIndex = 16;
            this.gbBugParm.TabStop = false;
            this.gbBugParm.Text = "Bug Parm";
            // 
            // tbBugsPath
            // 
            this.tbBugsPath.Location = new System.Drawing.Point(49, 99);
            this.tbBugsPath.Name = "tbBugsPath";
            this.tbBugsPath.Size = new System.Drawing.Size(501, 25);
            this.tbBugsPath.TabIndex = 18;
            this.tbBugsPath.Text = "C:\\Users\\Administrator\\Desktop\\somepoints.txt";
            // 
            // btFromFile
            // 
            this.btFromFile.Location = new System.Drawing.Point(440, 144);
            this.btFromFile.Name = "btFromFile";
            this.btFromFile.Size = new System.Drawing.Size(98, 23);
            this.btFromFile.TabIndex = 17;
            this.btFromFile.Text = "FromFile";
            this.btFromFile.UseVisualStyleBackColor = true;
            this.btFromFile.Click += new System.EventHandler(this.btFromFile_Click);
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(76, 144);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(98, 23);
            this.btRandom.TabIndex = 16;
            this.btRandom.Text = "Random";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // HeatbugConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 216);
            this.Controls.Add(this.gbBugParm);
            this.Controls.Add(this.gbWorldParm);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HeatbugConsole";
            this.Text = "HeatbugConsole";
            this.gbWorldParm.ResumeLayout(false);
            this.gbWorldParm.PerformLayout();
            this.gbBugParm.ResumeLayout(false);
            this.gbBugParm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox gbWorldParm;
        private System.Windows.Forms.TextBox tbWorldHeght;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWorldWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDisplayFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbScale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox tbIdealTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumBugs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBugParm;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.TextBox tbBugsPath;
        private System.Windows.Forms.Button btFromFile;
    }
}