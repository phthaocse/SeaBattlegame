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
        ShipManager tauSanBay;
        ShipManager tauKhuTruc;
        ShipManager tauTuanDuong;
        ShipManager tauDobo;
        #endregion
        List<List<Button>> matrix;
        int size = 0;

        public SeaBattle()
        {
            InitializeComponent();
            Board1 = new BoardManager(pnlBroad1,tbxName,tbxScore,pictureBox1,tbxbullet,tbxship);
            matrix = Board1.DrawBoard();
           // Board2 = new BoardManager(pnlBoard2, tbxName, tbxScore, pictureBox1, tbxbullet, tbxship);
           // matrix = Board2.DrawBoard();
            bar1 = new Drawbar(crossbar1, jamb1);
           // bar2 = new Drawbar(crossbar2, jamb2);
            bar1.DrawCrossbar();
            bar1.DrawJamp();
           // bar2.DrawCrossbar();
           // bar2.DrawJamp();
            tauSanBay = new ShipManager(btnAC, btnSet, tbx1, tby1, tbx2, tby2,matrix,size,shiptype.AC);
            tauSanBay.put();
            tauKhuTruc = new ShipManager(btnDestroyer, btnSet, tbx1, tby1, tbx2, tby2, matrix, size, shiptype.Destroyer);
            tauKhuTruc.put();
            tauTuanDuong = new ShipManager(btnCruiser, btnSet, tbx1, tby1, tbx2, tby2, matrix, size, shiptype.Cruiser);
            tauTuanDuong.put();
            tauDobo = new ShipManager(btnLC, btnSet, tbx1, tby1, tbx2, tby2, matrix, size, shiptype.LC);
            tauDobo.put();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {

        }
    }
}
