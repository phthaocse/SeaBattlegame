﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawBoard();
        }
        void DrawBoard()
        {
            Button btn = new Button();
            pnlBroad1.Controls.Add(btn);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}