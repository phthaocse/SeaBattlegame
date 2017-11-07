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
        BoardManager Board;
        #endregion
        public SeaBattle()
        {
            InitializeComponent();
            Board = new BoardManager(pnlBroad1,pnlBoard2);
            Board.DrawBoard();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
