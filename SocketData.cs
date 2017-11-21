using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    [Serializable]

    class SocketData
    {
        private int command;



        private Point point;


        private string message;


        private Bitmap btm;

        private int loaiHinh;

        private int player;

        public int Command
        {
            get
            {
                return command;
            }

            set
            {
                command = value;
            }
        }

        public Point Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public Bitmap Btm
        {
            get
            {
                return btm;
            }

            set
            {
                btm = value;
            }
        }

        public int LoaiHinh
        {
            get
            {
                return loaiHinh;
            }

            set
            {
                loaiHinh = value;
            }
        }

        public int Player
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

        //public SocketData(int command, string message, Point point)
        //{
        //    this.Command = command;
        //    this.Point = point;
        //    this.Message = message;

        //}

        public SocketData(int command, int loaihinh, Point point/*,int player*/, string message)
        {
            this.Command = command;
            this.Point = point;
            this.LoaiHinh = loaihinh;
            this.Message = message;
            //this.Player = player;


            //}

            //public SocketData(int command, string message, Point point, Bitmap btm)
            //{
            //    this.Command = command;
            //    this.Point = point;
            //    this.Message = message;
            //    this.Btm = btm;
            //}
        }
    }

    public enum SocketCommand
    {
        NOTIFY,
        SEND_POINT,
        RETURN_POINT,
        QUIT,
        END_GAME,
        START_GAME
    }
}
