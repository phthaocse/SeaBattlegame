using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
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

        ShipManager tauSanBay1;
        ShipManager tauKhuTruc1;
        ShipManager tauTuanDuong1;
        ShipManager tauDobo1;

        SocketManager socket;

        #endregion
        List<List<Button>> matrix1;
        List<List<Button>> matrix2;
        int size = 0;
        bool player1;

        public SeaBattle()
        {
            InitializeComponent();

            Board1 = new BoardManager(pnlBroad1/*,tbxName,tbxScore,pictureBox1,tbxbullet,tbxship*/);
            Board2 = new BoardManager(pnlBoard2/*, tbxName, tbxScore, pictureBox1, tbxbullet, tbxship*/);

            NewGame();

            
            
            Board1.PlayerMarked += Board1_PlayerMarked;
            Board1.PlayerReturn += Board1_PlayerReturn;

            Board2.PlayerMarked += Board2_PlayerMarked;
            Board2.PlayerReturn += Board2_PlayerReturn;

            Board1.PlayerWin += Board1_PlayerWin;
            Board2.PlayerWin += Board2_PlayerWin;

            Board1.ThongBao += Board1_ThongBao;
            Board2.ThongBao += Board2_ThongBao;

            socket = new SocketManager();

            bar1 = new Drawbar(crossbar1, jamb1);
            bar2 = new Drawbar(crossbar2, jamb2);

            bar1.DrawCrossbar();
            bar1.DrawJamp();
            bar2.DrawCrossbar();
            bar2.DrawJamp();


            //tauSanBay = new ShipManager(btnAC, btnSet, tbx1, tby1, tbx2, tby2,matrix,size,shiptype.AC);
            //tauSanBay.put();
            //tauKhuTruc = new ShipManager(btnDestroyer, btnSet, tbx1, tby1, tbx2, tby2, matrix, size, shiptype.Destroyer);
            //tauKhuTruc.put();
            //tauTuanDuong = new ShipManager(btnCruiser, btnSet, tbx1, tby1, tbx2, tby2, matrix, size, shiptype.Cruiser);
            //tauTuanDuong.put();
            //tauDobo = new ShipManager(btnLC, btnSet, tbx1, tby1, tbx2, tby2, matrix, size, shiptype.LC);
            //tauDobo.put();
        }

        private void Board2_ThongBao(object sender, GetText e)
        {
            socket.Send(new SocketData((int)SocketCommand.NOTIFY, 0, new Point()/*,e.Player*/, e.Text));
        }

        private void Board1_ThongBao(object sender, GetText e)
        {
            socket.Send(new SocketData((int)SocketCommand.NOTIFY, 0, new Point()/*,e.Player*/, e.Text));
        }

        private void Board2_PlayerWin(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã thua !");
            socket.Send(new SocketData((int)SocketCommand.END_GAME, 0, new Point()/*,e.Player*/,""));
        }

        private void Board1_PlayerWin(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã thua !");
            socket.Send(new SocketData((int)SocketCommand.END_GAME, 0, new Point()/*,e.Player*/,""));
        }

        private void Board2_PlayerReturn(object sender, ButtonChange e)
        {
            socket.Send(new SocketData((int)SocketCommand.RETURN_POINT, e.LoaiHinh, e.Point/*,e.Player*/,""));
            //Listen();
        }

        private void Board2_PlayerMarked(object sender, ButtonClickEvent e)
        {
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, 5, e.ClickedPoint/*,e.Player*/,""));

            //ChessBoard.OtherPlayerMark(e.ClickedPoint);
            //ChessBoard.playerreturn(data.Point);

            Listen();
        }

        private void Board1_PlayerReturn(object sender, ButtonChange e)
        {
            socket.Send(new SocketData((int)SocketCommand.RETURN_POINT, e.LoaiHinh, e.Point/*,e.Player*/,""));
        }

        private void Board1_PlayerMarked(object sender, ButtonClickEvent e)
        {
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, e.LoaiHinh, e.ClickedPoint/*,e.Player*/,""));

            //ChessBoard.OtherPlayerMark(e.ClickedPoint);
            //ChessBoard.playerreturn(data.Point);

            Listen();
        }



        void Listen()
        {

            Thread listenThread = new Thread(() =>
            {
                try
                {

                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);

                }
                catch (Exception e)
                {

                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();




        }



        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message,"Thông Báo");
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {

                        if (player1 == false)
                        {
                            int test = Board2.OtherPlayerMark(data.Point, data.LoaiHinh);
                            if (test == 0)
                            {
                                pnlBoard2.Enabled = false;
                                pnlBroad1.Enabled = true;
                            }
                            else
                            {
                                pnlBoard2.Enabled = false;
                                pnlBroad1.Enabled = false;
                            }
                        }
                        else
                        {
                            int test = Board1.OtherPlayerMark(data.Point, data.LoaiHinh);
                            if (test == 0)
                            {
                                pnlBoard2.Enabled = true;
                                pnlBroad1.Enabled = false;
                            }
                            else
                            {
                                pnlBoard2.Enabled = false;
                                pnlBroad1.Enabled = false;
                            }
                        }

                        //pnlChessBoard.Enabled = true;


                        //socket.Send(data.Point);
                    }));
                    break;
                case (int)SocketCommand.RETURN_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        if (data.LoaiHinh == 0)
                        {
                            if (player1 == false)
                            {
                                Board1.ReturnButtom(data.Point, data.LoaiHinh);
                                pnlBoard2.Enabled = false;
                                pnlBroad1.Enabled = false;
                            }
                            else
                            {
                                Board2.ReturnButtom(data.Point, data.LoaiHinh);
                                pnlBoard2.Enabled = false;
                                pnlBroad1.Enabled = false;
                            }
                        }
                        else
                        {
                            if (player1 == true)
                            {
                                Board2.ReturnButtom(data.Point, data.LoaiHinh);
                                pnlBoard2.Enabled = true;
                                pnlBroad1.Enabled = false;
                            }
                            else
                            {
                                Board1.ReturnButtom(data.Point, data.LoaiHinh);
                                pnlBoard2.Enabled = false;
                                pnlBroad1.Enabled = true;
                            }
                        }

                        //pnlChessBoard.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.QUIT:
                    MessageBox.Show("Người chơi đã thoát","Thông Báo");
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("Bạn đã thắng !", "Thông Báo");
                    break;
                case (int)SocketCommand.START_GAME:
                    MessageBox.Show("Nguoi Choi Da San Sang!", "Thông Báo");
                    break;
                default:
                    break;
            }
            Listen();
        }






        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        //private void btnSet_Click(object sender, EventArgs e)
        //{

        //}

        private void btnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;
            
            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                player1 = true;
                //pnlChessBoard.Enabled = true;
                pnlBroad1.Enabled = false;
                pnlBoard2.Enabled = true;
                Board1.SetScreen(0, tbxName, tbxScore, pictureBox1, tbxbullet, tbxship,ScreenGame.NamePlayer.name);
                Board2.SetScreen(0, tbxName, tbxScore, pictureBox1, tbxbullet, tbxship, ScreenGame.NamePlayer.name);
                tauSanBay = new ShipManager(btnAC, btnSet, tbx1, tby1, tbx2, tby2, matrix1, size, shiptype.AC);

                tauKhuTruc = new ShipManager(btnDestroyer, btnSet, tbx1, tby1, tbx2, tby2, matrix1, size, shiptype.Destroyer);

                tauTuanDuong = new ShipManager(btnCruiser, btnSet, tbx1, tby1, tbx2, tby2, matrix1, size, shiptype.Cruiser);

                tauDobo = new ShipManager(btnLC, btnSet, tbx1, tby1, tbx2, tby2, matrix1, size, shiptype.LC);
                tauSanBay.put();
                tauKhuTruc.put();
                tauTuanDuong.put();
                tauDobo.put();

                socket.CreateServer();

                btnSTART.Click += BtnSTART_Click;
            }
            else
            {
                player1 = false;
                socket.isServer = false;
                pnlBroad1.Enabled = false;
                pnlBoard2.Enabled = false;
                
                Board1.SetScreen(1, tbxName, tbxScore, pictureBox1, tbxbullet, tbxship, ScreenGame.NamePlayer.name);
                Board2.SetScreen(1, tbxName, tbxScore, pictureBox1, tbxbullet, tbxship, ScreenGame.NamePlayer.name);

                tauSanBay1 = new ShipManager(btnAC, btnSet, tbx1, tby1, tbx2, tby2, matrix2, size, shiptype.AC);

                tauKhuTruc1 = new ShipManager(btnDestroyer, btnSet, tbx1, tby1, tbx2, tby2, matrix2, size, shiptype.Destroyer);

                tauTuanDuong1 = new ShipManager(btnCruiser, btnSet, tbx1, tby1, tbx2, tby2, matrix2, size, shiptype.Cruiser);

                tauDobo1 = new ShipManager(btnLC, btnSet, tbx1, tby1, tbx2, tby2, matrix2, size, shiptype.LC);
                tauSanBay1.put();
                tauKhuTruc1.put();
                tauTuanDuong1.put();
                tauDobo1.put();

                btnSTART.Click += BtnSTART_Click1;  

                //pnlChessBoard.Enabled = false;
                Listen();

            }
        }

        private void BtnSTART_Click1(object sender, EventArgs e)
        {
            if (tauSanBay.SoLuongTau + tauKhuTruc.SoLuongTau + tauTuanDuong.SoLuongTau + tauDobo.SoLuongTau < 9)
            {
                MessageBox.Show("Ban hay chon lai");
            }
            else
            {
                socket.Send(new SocketData((int)SocketCommand.START_GAME, 0, new Point()/*,e.Player*/, ""));
            }
        }

        private void BtnSTART_Click(object sender, EventArgs e)
        {
            if(tauSanBay.SoLuongTau + tauKhuTruc.SoLuongTau + tauTuanDuong.SoLuongTau + tauDobo.SoLuongTau < 9)
            {
                MessageBox.Show("Ban hay chon lai");
            }
            
        }

        private void SeaBattle_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void NewGame()
        {
            matrix1 = Board1.DrawBoard();
            matrix2 = Board2.DrawBoard();
        }

        void Quit()
        {
            Application.Exit();
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void SeaBattle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát !", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
            {
                socket.Send(new SocketData((int)SocketCommand.QUIT, 0, new Point()/*,e.Player*/,""));
            }
        }

        private void SeaBattle_Load(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
