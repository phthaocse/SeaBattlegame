using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SeaBattle
{
    class BoardManager
    {
        #region Propeties
        private Panel Board1;
        private Panel Board2;
        public Panel board1
        {
            get { return Board1; }
            set { Board1 = value; }
        }
        public Panel board2
        {
            get { return Board2; }
            set { Board2 = value; }
        }

        #endregion
        #region Initialize
        public BoardManager(Panel _Board1, Panel _Board2)
        {
            this.Board1 = _Board1;
            this.Board2 = _Board2;
        }

        #endregion
        #region Method
        public void DrawBoard()
        {
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };// khoi tao diem bat dau
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Contents.square_width,
                        Height = Contents.square_height,
                        // location la toa do cua 1 diem, thay doi toa do diem sau bang toa do trc cong width
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y)
                    }; // khoi tao mot button voi kich thuoc da quy dinh
                    Board1.Controls.Add(btn);
                    oldbtn = btn;
                }
                //gan lai vi tri old button khi xuong dong
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Contents.square_height);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
            //ve board2
            oldbtn.Location = new Point(0, 0);
            oldbtn.Width = 0;
            oldbtn.Height = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Contents.square_width,
                        Height = Contents.square_height,
                        // location la toa do cua 1 diem, thay doi toa do diem sau bang toa do trc cong width
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y)
                    }; // khoi tao mot button voi kich thuoc da quy dinh
                    Board2.Controls.Add(btn);
                    oldbtn = btn;
                }
                //gan lai vi tri old button khi xuong dong
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Contents.square_height);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
        }
        #endregion

    }
}
