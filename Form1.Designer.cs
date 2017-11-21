using System;

namespace SeaBattle
{
    partial class SeaBattle
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
            this.pnlBroad1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxship = new System.Windows.Forms.TextBox();
            this.tbxbullet = new System.Windows.Forms.TextBox();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tby2 = new System.Windows.Forms.TextBox();
            this.tby1 = new System.Windows.Forms.TextBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.btnLC = new System.Windows.Forms.Button();
            this.btnDestroyer = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnCruiser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crossbar1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.crossbar2 = new System.Windows.Forms.Panel();
            this.jamb2 = new System.Windows.Forms.Panel();
            this.jamb1 = new System.Windows.Forms.Panel();
            this.pnlBoard2 = new System.Windows.Forms.Panel();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSTART = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.crossbar1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBroad1
            // 
            this.pnlBroad1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlBroad1.Location = new System.Drawing.Point(35, 93);
            this.pnlBroad1.Name = "pnlBroad1";
            this.pnlBroad1.Size = new System.Drawing.Size(300, 300);
            this.pnlBroad1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbxship);
            this.panel3.Controls.Add(this.tbxbullet);
            this.panel3.Controls.Add(this.tbxScore);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.tbxName);
            this.panel3.Location = new System.Drawing.Point(727, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 151);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(153, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ship";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bullets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score ";
            // 
            // tbxship
            // 
            this.tbxship.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxship.Location = new System.Drawing.Point(201, 118);
            this.tbxship.Name = "tbxship";
            this.tbxship.ReadOnly = true;
            this.tbxship.Size = new System.Drawing.Size(40, 30);
            this.tbxship.TabIndex = 5;
            // 
            // tbxbullet
            // 
            this.tbxbullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxbullet.Location = new System.Drawing.Point(67, 118);
            this.tbxbullet.Name = "tbxbullet";
            this.tbxbullet.ReadOnly = true;
            this.tbxbullet.Size = new System.Drawing.Size(40, 30);
            this.tbxbullet.TabIndex = 4;
            // 
            // tbxScore
            // 
            this.tbxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxScore.Location = new System.Drawing.Point(67, 71);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.ReadOnly = true;
            this.tbxScore.Size = new System.Drawing.Size(73, 30);
            this.tbxScore.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(157, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(3, 25);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(148, 20);
            this.tbxName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Controls.Add(this.tbx2);
            this.panel1.Controls.Add(this.tby2);
            this.panel1.Controls.Add(this.tby1);
            this.panel1.Controls.Add(this.tbx1);
            this.panel1.Controls.Add(this.btnLC);
            this.panel1.Controls.Add(this.btnDestroyer);
            this.panel1.Controls.Add(this.btnAC);
            this.panel1.Controls.Add(this.btnCruiser);
            this.panel1.Location = new System.Drawing.Point(727, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 282);
            this.panel1.TabIndex = 4;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(45, 234);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(196, 24);
            this.btnSet.TabIndex = 16;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(36, 204);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(80, 20);
            this.tbx2.TabIndex = 15;
            // 
            // tby2
            // 
            this.tby2.Location = new System.Drawing.Point(171, 204);
            this.tby2.Name = "tby2";
            this.tby2.Size = new System.Drawing.Size(80, 20);
            this.tby2.TabIndex = 14;
            // 
            // tby1
            // 
            this.tby1.Location = new System.Drawing.Point(171, 171);
            this.tby1.Name = "tby1";
            this.tby1.Size = new System.Drawing.Size(80, 20);
            this.tby1.TabIndex = 13;
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(36, 171);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(80, 20);
            this.tbx1.TabIndex = 12;
            // 
            // btnLC
            // 
            this.btnLC.Location = new System.Drawing.Point(67, 124);
            this.btnLC.Name = "btnLC";
            this.btnLC.Size = new System.Drawing.Size(150, 30);
            this.btnLC.TabIndex = 11;
            this.btnLC.Text = "Tàu Đổ Bộ";
            this.btnLC.UseVisualStyleBackColor = true;
            this.btnLC.Click += new System.EventHandler(this.btnLC_Click);
            // 
            // btnDestroyer
            // 
            this.btnDestroyer.Location = new System.Drawing.Point(67, 52);
            this.btnDestroyer.Name = "btnDestroyer";
            this.btnDestroyer.Size = new System.Drawing.Size(150, 30);
            this.btnDestroyer.TabIndex = 4;
            this.btnDestroyer.Text = "Tàu Khu Trục";
            this.btnDestroyer.UseVisualStyleBackColor = true;
            this.btnDestroyer.Click += new System.EventHandler(this.btnDestroyer_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(67, 16);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(150, 30);
            this.btnAC.TabIndex = 2;
            this.btnAC.Text = "Tàu Sân Bay";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnCruiser
            // 
            this.btnCruiser.Location = new System.Drawing.Point(68, 88);
            this.btnCruiser.Name = "btnCruiser";
            this.btnCruiser.Size = new System.Drawing.Size(150, 30);
            this.btnCruiser.TabIndex = 3;
            this.btnCruiser.Text = "Tàu Tuần Dương";
            this.btnCruiser.UseVisualStyleBackColor = true;
            this.btnCruiser.Click += new System.EventHandler(this.bntCruiser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLAYER 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLAYER 2";
            // 
            // crossbar1
            // 
            this.crossbar1.Controls.Add(this.panel10);
            this.crossbar1.Location = new System.Drawing.Point(35, 63);
            this.crossbar1.Name = "crossbar1";
            this.crossbar1.Size = new System.Drawing.Size(300, 30);
            this.crossbar1.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(20, 30);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 300);
            this.panel10.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(169, 76);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(30, 300);
            this.panel11.TabIndex = 10;
            // 
            // crossbar2
            // 
            this.crossbar2.Location = new System.Drawing.Point(391, 63);
            this.crossbar2.Name = "crossbar2";
            this.crossbar2.Size = new System.Drawing.Size(300, 30);
            this.crossbar2.TabIndex = 8;
            // 
            // jamb2
            // 
            this.jamb2.Location = new System.Drawing.Point(361, 93);
            this.jamb2.Name = "jamb2";
            this.jamb2.Size = new System.Drawing.Size(30, 300);
            this.jamb2.TabIndex = 9;
            // 
            // jamb1
            // 
            this.jamb1.Location = new System.Drawing.Point(3, 93);
            this.jamb1.Name = "jamb1";
            this.jamb1.Size = new System.Drawing.Size(30, 300);
            this.jamb1.TabIndex = 10;
            // 
            // pnlBoard2
            // 
            this.pnlBoard2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlBoard2.Location = new System.Drawing.Point(391, 93);
            this.pnlBoard2.Name = "pnlBoard2";
            this.pnlBoard2.Size = new System.Drawing.Size(300, 300);
            this.pnlBoard2.TabIndex = 1;
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(898, 490);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(75, 23);
            this.btnLAN.TabIndex = 11;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(743, 490);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(100, 20);
            this.txbIP.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // btnSTART
            // 
            this.btnSTART.Location = new System.Drawing.Point(555, 471);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(75, 23);
            this.btnSTART.TabIndex = 14;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = true;
            // 
            // SeaBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 525);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.btnLAN);
            this.Controls.Add(this.jamb1);
            this.Controls.Add(this.jamb2);
            this.Controls.Add(this.crossbar2);
            this.Controls.Add(this.crossbar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBoard2);
            this.Controls.Add(this.pnlBroad1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SeaBattle";
            this.Text = "Set";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeaBattle_FormClosing);
            this.Load += new System.EventHandler(this.SeaBattle_Load);
            this.Shown += new System.EventHandler(this.SeaBattle_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.crossbar1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bntCruiser_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDestroyer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel pnlBroad1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel crossbar1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel crossbar2;
        private System.Windows.Forms.Panel jamb2;
        private System.Windows.Forms.Panel jamb1;
        private System.Windows.Forms.Panel pnlBoard2;
        private System.Windows.Forms.Button btnDestroyer;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnCruiser;
        private System.Windows.Forms.Button btnLC;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tby2;
        private System.Windows.Forms.TextBox tby1;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.TextBox tbxship;
        private System.Windows.Forms.TextBox tbxbullet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button btnSTART;
    }
}

