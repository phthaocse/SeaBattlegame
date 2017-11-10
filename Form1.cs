using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class SeaBattle : Form
    {
        #region Propeties
        BoardManager Board1;
        BoardManager Board2;
        Drawbar bar1;
        Drawbar bar2;
        #endregion
        public SeaBattle()
        {
            InitializeComponent();
            Board1 = new BoardManager(pnlBroad1);
            Board1.DrawBoard();
            Board2 = new BoardManager(pnlBoard2);
            Board2.DrawBoard();
            bar1 = new Drawbar(crossbar1, jamb1);
            bar2 = new Drawbar(crossbar2, jamb2);
            bar1.DrawCrossbar();
            bar1.DrawJamp();
            bar2.DrawCrossbar();
            bar2.DrawJamp();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
