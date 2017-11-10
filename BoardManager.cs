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
        private Panel board;
        public Panel Board
        {
            get
            {
                return board;
            }

            set
            {
                board = value;
            }
        }
        #endregion
        #region Initialize
        public BoardManager(Panel _Board)
        {
            this.Board = _Board;
        }
        #endregion
        #region Method
        public void DrawBoard()
        {
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };// khoi tao diem bat dau
            for (int i = 0; i < Contents.board_height; i++)
            {
                for (int j = 0; j < Contents.board_width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Contents.square_width,
                        Height = Contents.square_height,
                        Location = new Point(j*Contents.square_width, oldbtn.Location.Y)//sau moi lan thi toa do cua button tren 1 hang bi doi qua 1 do rong tuong ung 
                    }; // khoi tao mot button voi kich thuoc da quy dinh
                    Board.Controls.Add(btn);
                    
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
