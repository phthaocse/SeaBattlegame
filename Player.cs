using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    class Player
    {
        private string name;
        private Image mark;//luu hinh hien thi cua button
        private int score;
        private int nship;
        private int bullet;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Image Mark
        {
            get
            {
                return mark;
            }

            set
            {
                mark = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        public int Nship
        {
            get
            {
                return nship;
            }

            set
            {
                nship = value;
            }
        }

        public int Bullet
        {
            get
            {
                return bullet;
            }

            set
            {
                bullet = value;
            }
        }

        public Player(string name, Image mark, int score,int nship, int bullet)
        {
            this.Name = name;
            this.Mark = mark;
            this.Score = score;
            this.Bullet = bullet;
            this.Nship = nship;
        }
    }
}
