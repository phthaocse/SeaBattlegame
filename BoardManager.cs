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
        private List<Player> player;
        private List<List<Button>> matrix;
        private int currentPlayer;
        private int bonus;
        private TextBox playerName;
        private TextBox playerScore;
        private TextBox playerShip;
        private TextBox playerBullet;
        private PictureBox playerMark;

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

        internal List<Player> Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public int CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }

            set
            {
                currentPlayer = value;
            }
        }

        public List<List<Button>> Matrix
        {
            get
            {
                return matrix;
            }

            set
            {
                matrix = value;
            }
        }

        public TextBox PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public PictureBox PlayerMark
        {
            get
            {
                return playerMark;
            }

            set
            {
                playerMark = value;
            }
        }

        public TextBox PlayerScore
        {
            get
            {
                return playerScore;
            }

            set
            {
                playerScore = value;
            }
        }

        public TextBox PlayerShip
        {
            get
            {
                return playerShip;
            }

            set
            {
                playerShip = value;
            }
        }

        public TextBox PlayerBullet
        {
            get
            {
                return playerBullet;
            }

            set
            {
                playerBullet = value;
            }
        }

        public int Bonus
        {
            get
            {
                return bonus;
            }

            set
            {
                bonus = value;
            }
        }
        #endregion
        #region Initialize
        public BoardManager(Panel _Board, TextBox playerName, TextBox playerScore, PictureBox mark, TextBox playerbullet, TextBox playership)
        {
            this.Board = _Board;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.PlayerScore = playerScore;
            this.PlayerShip = playership;
            this.PlayerBullet = playerbullet;
            this.Player = new List<Player>()
            {
                new Player("Player1", Image.FromFile(Application.StartupPath + "\\Resources\\P1.png"), 0, 9, 0),
                new Player("Player2", Image.FromFile(Application.StartupPath + "\\Resources\\P2.jpeg"), 0, 9, 0),
            };

            this.CurrentPlayer = 0;
            this.Bonus = 0;
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
            PlayerScore.Text = Player[CurrentPlayer].Score.ToString();
            PlayerBullet.Text = Player[CurrentPlayer].Bullet.ToString();
            PlayerShip.Text = Player[CurrentPlayer].Nship.ToString();
        }
        #endregion
        #region Method
        public List<List<Button>> DrawBoard()
        {
            Matrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };// khoi tao diem bat dau
            for (int i = 0; i < Contents.board_height; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Contents.board_width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Contents.square_width,
                        Height = Contents.square_height,
                        Location = new Point(j * Contents.square_width, oldbtn.Location.Y),//sau moi lan thi toa do cua button tren 1 hang bi doi qua 1 do rong tuong ung 
                        BackgroundImageLayout = ImageLayout.Stretch, // scale hinh theo button
                        Tag = i.ToString()                        
                    }; // khoi tao mot button voi kich thuoc da quy dinh
                    btn.Click += Btn_Click;
                    Board.Controls.Add(btn);
                    Matrix[i].Add(btn);  ////add cac button vao mot ma tran de luu tru
                    

                }
                //gan lai vi tri old button khi xuong dong
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Contents.square_height);
                oldbtn.Width = 0;
                oldbtn.Height = 0;

            }
            return Matrix;
        
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Player[CurrentPlayer].Bullet++;
            if (test(btn) == false) { ChangePlayer(); }  ////kiem tra button duoc nhap vao
        }

        //lay toa do button duoc click
        private Point getPoint(Button btn)
        {
            int y = Convert.ToInt32(btn.Tag);
            int x = Matrix[y].IndexOf(btn);
            Point point = new Point(x,y);
            return point;
        }

        private bool isDestroyed(Button btn, shiptype type)
        {
            //check
            int _type = Convert.ToInt32(type) + 1;
            if (rowTest(btn,_type) || colTest(btn,_type))
            {
                if (_type == 5)
                {
                    MessageBox.Show("Bạn đã bắn trúng tàu sân bay", "Chúc mừng");
                    return true;
                }
                if (_type == 3)
                {
                    MessageBox.Show("Bạn đã bắn trúng tàu khu trục", "Chúc mừng");
                    return true;
                }
                if (_type == 2)
                {
                    MessageBox.Show("Bạn đã bắn trúng tàu tuần dương", "Chúc mừng");
                    return true;
                }
                if (_type == 1)
                {
                    MessageBox.Show("Bạn đã bắn trúng tàu đổ bộ", "Chúc mừng");
                    return true;
                }
            }
            return false;
        }

        private bool isEndgame(Button btn)
        {
            int tmp = CurrentPlayer == 0 ? 1 : 0;// lay idx doi thu neu het tau la thua
            if (Player[tmp].Nship == 0) return true;
            return false;
        }

        private void Endgame()
        {
            MessageBox.Show(Player[CurrentPlayer].Name + "đã chiến thắng", "Chúc mừng");
        }

        private bool test(Button btn)
        {
            Point point = getPoint(btn);
            Bitmap btmAC = new Bitmap(Application.StartupPath + "\\Resources\\mau_do.png");//lay hinh nen button ra
            Bitmap btmDestroy = new Bitmap(Application.StartupPath + "\\Resources\\mau_vang.png");
            Bitmap btmCruiser = new Bitmap(Application.StartupPath + "\\Resources\\mau_cam.png");
            Bitmap btmLC = new Bitmap(Application.StartupPath + "\\Resources\\mau_xanh_la.jpg");
            //xu ly xem button duoc click dang la vi tri cua tau nao
            if (Matrix[point.Y][point.X].BackgroundImage != null)
            {
                Bitmap btmBackGround = new Bitmap(btn.BackgroundImage);
                int tmp = CurrentPlayer == 0 ? 1 : 0;// lay idx doi thu
                if (btmBackGround.Size == btmAC.Size)
                {
                    imageChange(btn, 1);
                    if(isDestroyed(btn,shiptype.AC) == true) Player[tmp].Nship--;
                }
                if (btmBackGround.Size == btmDestroy.Size)
                {
                    imageChange(btn, 1);
                    if(isDestroyed(btn, shiptype.Destroyer) == true) Player[tmp].Nship--;
                }
                if (btmBackGround.Size == btmCruiser.Size)
                {
                    imageChange(btn, 1);
                    if(isDestroyed(btn, shiptype.Cruiser) == true) Player[tmp].Nship--;
                }
                if (btmBackGround.Size == btmLC.Size)
                {
                    imageChange(btn, 1);
                    if(isDestroyed(btn, shiptype.LC) == true) Player[tmp].Nship--;
                }
                Player[CurrentPlayer].Score += (10 + (int)Math.Pow(2,Bonus));
                Bonus++;
                if (isEndgame(btn) == true) { Endgame();}
                return true;// duoc tiep tuc ban tiep 
            }
            else
            {
                imageChange(btn, 0);
                Bonus = 0;
            }
           
            return false;

        }

        private bool rowTest(Button btn, int type)
        {
            int countLeft = 0;
            int countRight = 0;
            Point point = getPoint(btn);


            Color color = Color.White;
            if (type == 5)
            {
                color = Color.Red;
               
            }
            if (type == 3)
            {
                color = Color.Yellow;
          
            }
            if (type == 2)
            {
                color = Color.Orange;
            }
            if (type == 1)
            {
                color = Color.Green;
            }
            
            
            for (int i = point.X; i < Contents.board_width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage != null)
                {
                    if (Matrix[point.Y][i].BackgroundImage.Width == btn.BackgroundImage.Width && Matrix[point.Y][i].BackColor == color)
                    {
                        countRight++;
                    }
                    else break;
                }
                else break;
            }
            for(int i = (point.X - 1); i>=0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage != null)
                {

                    if (Matrix[point.Y][i].BackgroundImage.Width == btn.BackgroundImage.Width && Matrix[point.Y][i].BackColor == color)
                    {
                        countLeft++;
                    }
                    else break;
                }
                else break;
            }
            
            
            return (countLeft + countRight) == type;

        }

        private bool colTest(Button btn, int type)
        {
            int countTop = 0;
            int countBottom = 0;
            Point point = getPoint(btn);

            Color color = Color.White;
            if (type == 5)
            {
                color = Color.Red;

            }
            if (type == 3)
            {
                color = Color.Yellow;

            }
            if (type == 2)
            {
                color = Color.Orange;
            }
            if (type == 1)
            {
                color = Color.Green;
            }

            
            for (int i = point.Y; i < Contents.board_height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage != null)
                {
                    if (Matrix[i][point.X].BackgroundImage.Width == btn.BackgroundImage.Width && Matrix[i][point.X].BackColor == color)
                    {
                        countBottom++;
                    }
                    else break;
                }
                else break;
            }
            for (int i = point.Y - 1; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage != null)
                {
                    if (Matrix[i][point.X].BackgroundImage.Width == btn.BackgroundImage.Width && Matrix[i][point.X].BackColor == color)
                    {
                        countTop++;
                    }
                    else break;
                }
                else break;
            }

            return (countTop + countBottom) == type;

        }

        //thay doi hinh tuong ung voi trang thai khi ban vao o do   
        private bool imageChange(Button btn, int status)
        {
            Point point = getPoint(btn);
            if (status == 0)//ban hut
            {
                Matrix[point.Y][point.X].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\X_mark.png");
                btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\X_mark.png");
                return true;
            }
            if (status == 1)//ban trung
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Resources\\bom1.jpg");
                Matrix[point.Y][point.X].BackgroundImage = image;
                btn.BackgroundImage = image;
                return true;
            }
            return false;
        }

        private void ChangePlayer()
        {
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
            PlayerScore.Text = Player[CurrentPlayer].Score.ToString();
            PlayerBullet.Text = Player[CurrentPlayer].Bullet.ToString();
            PlayerShip.Text = Player[CurrentPlayer].Nship.ToString();
        }
        #endregion

    }
}
