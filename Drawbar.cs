using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    class Drawbar
    {
        #region Propeties
        private Panel crossbar;
        private Panel jamb;

        public Panel Crossbar
        {
            get { return crossbar; }
            set { crossbar = value; }
        }

        public Panel Jamb
        {
            get { return jamb;}

            set { jamb = value;}
        }
        #endregion
        #region Initialize
        public Drawbar(Panel pnl1, Panel pnl2)
        {
            this.Crossbar = pnl1;
            this.Jamb = pnl2;
        }
        #endregion
        #region Method
        //ve thanh ngang thanh doc
        public void DrawCrossbar()
        {
            Label old_lb = new Label() { Width = 0, Height = 0, Location = new Point(0, 0) };// khoi tao diem bat dau 
            int start = 0; // dem tu 1
            for (int i = start; i <= Contents.board_width; i++)
            {
                Label lb = new Label()
                {
                    Width = Contents.square_width,
                    Height = Contents.square_height,
                    Location = new Point(i * Contents.square_width, old_lb.Location.Y),
                    Text = (i + 1).ToString(),
                    TextAlign = System.Drawing.ContentAlignment.BottomCenter //set vi tri chu trong label
                }; // khoi tao mot label voi kich thuoc da quy dinh
                Crossbar.Controls.Add(lb);
                old_lb = lb;
            }
        }

        public void DrawJamp()
        {
            Label old_lb = new Label() { Width = 0, Height = 0, Location = new Point(0, 0) };// khoi tao diem bat dau 
            int start = 0; // dem tu 1
            for (int i = start; i <= Contents.board_height; i++)
            {
                Label lb = new Label()
                {
                    Width = Contents.square_width,
                    Height = Contents.square_height,
                    Location = new Point(old_lb.Location.X, i * Contents.square_height),
                    Text = (i + 1).ToString(),
                    TextAlign = System.Drawing.ContentAlignment.MiddleRight //set vi tri chu trong label
                }; // khoi tao mot label voi kich thuoc da quy dinh
                Jamb.Controls.Add(lb);
                old_lb = lb;
            }
        }
        #endregion


    }
}

    
