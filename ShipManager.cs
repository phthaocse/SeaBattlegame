using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public enum shiptype { AC = 4, Destroyer = 2, Cruiser = 1, LC = 0 };
    class ShipManager
    {
        #region Propeties
        private Button btn;
        private Button set;
        private TextBox tbX1;// hoanh do dau
        private TextBox tbY1;// tung do dau
        private TextBox tbX2;// hoang do cuoi
        private TextBox tbY2;// tung do cuoi 
        private List<List<Button>> matrix;
        private int soLuongTau;
        private shiptype type;// loai tau

        public Button Btn
        {
            get
            {
                return btn;
            }

            set
            {
                btn = value;
            }
        }

        public Button Set
        {
            get
            {
                return set;
            }

            set
            {
                set = value;
            }
        }

        public TextBox TbX1
        {
            get
            {
                return tbX1;
            }

            set
            {
                tbX1 = value;
            }
        }

        public TextBox TbY1
        {
            get
            {
                return tbY1;
            }

            set
            {
                tbY1 = value;
            }
        }

        public TextBox TbX2
        {
            get
            {
                return tbX2;
            }

            set
            {
                tbX2 = value;
            }
        }

        public TextBox TbY2
        {
            get
            {
                return tbY2;
            }

            set
            {
                tbY2 = value;
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

        public int SoLuongTau
        {
            get
            {
                return soLuongTau;
            }

            set
            {
                soLuongTau = value;
            }
        }

        private shiptype Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        #endregion
        #region Initialize
        public ShipManager(Button btn, Button set, TextBox tbX1, TextBox tbY1, TextBox tbX2, TextBox tbY2, List<List<Button>> matrix, int n, shiptype type)
        {
            this.Btn = btn;
            this.Set = set;
            this.TbX1 = tbX1;
            this.TbY1 = tbY1;
            this.TbX2 = tbX2;
            this.TbY2 = tbY2;
            this.Matrix = matrix;
            this.SoLuongTau = n;
            this.Type = type;
        }
        #endregion
        #region Methods
        public void put()
        {

            Btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            SoLuongTau += 1;
            //kiem tra so tau nhap hop le
            if (Type == shiptype.AC && SoLuongTau > 1)//tau san bay chi duoc 1 tau
            {
                Set.Enabled = false;
                MessageBox.Show("Đã chọn đủ không được chọn thêm loại tàu này nữa", "Error");
            }
            if (Type == shiptype.Destroyer && SoLuongTau > 2)// tau khu truc chi co 2 tau
            {
                Set.Enabled = false;
                MessageBox.Show("Đã chọn đủ không được chọn thêm loại tàu này nữa", "Error");
            }
            if (Type == shiptype.Cruiser && SoLuongTau > 3)// tau tuan duong chi co 3 tau
            {
                Set.Enabled = false;
                MessageBox.Show("Đã chọn đủ không được chọn thêm loại tàu này nữa", "Error");
            }
            if (Type == shiptype.LC && SoLuongTau > 3)// tau do bo chi co 3 tau
            {
                Set.Enabled = false;
                MessageBox.Show("Đã chọn đủ không được chọn thêm loại tàu này nữa", "Error");
            }
            else
            {
                TbX1.Enabled = true;
                TbX2.Enabled = true;
                TbY1.Enabled = true;
                TbY2.Enabled = true;

                Set.Enabled = true;

                Set.Click += Set_Click;

            }
        }

        public bool TestArea(int y1, int x1, int y2, int x2)
        {
            bool testUP = true, testBOTTOM = true, testRIGHT = true, testLEFT = true;
            if (y1 == 1)
            {
                if (x1 == 1)
                {
                    testBOTTOM = testDuoi(y1, x1, y2, x2);
                    testRIGHT = testPhai(y1, x1, y2, x2);
                }
                else if (x2 == Contents.board_width)
                {
                    testBOTTOM = testDuoi(y1, x1, y2, x2);
                    testLEFT = testTrai(y1, x1, y2, x2);
                }
                else
                {
                    testBOTTOM = testDuoi(y1, x1, y2, x2);
                    testRIGHT = testPhai(y1, x1, y2, x2);
                    testLEFT = testTrai(y1, x1, y2, x2);
                }
            }

            else if (y1 == Contents.board_height)
            {
                if (x1 == 1)
                {
                    testUP = testTren(y1, x1, y2, x2);
                    testRIGHT = testPhai(y1, x1, y2, x2);
                }
                else if (x2 == Contents.board_width)
                {
                    testUP = testTren(y1, x1, y2, x2);
                    testLEFT = testTrai(y1, x1, y2, x2);
                }
                else
                {
                    testUP = testTren(y1, x1, y2, x2);
                    testLEFT = testTrai(y1, x1, y2, x2);
                    testRIGHT = testPhai(y1, x1, y2, x2);
                }
            }

            else if (x1 == 1)
            {
                testUP = testTren(y1, x1, y2, x2);
                testRIGHT = testPhai(y1, x1, y2, x2);
                testBOTTOM = testDuoi(y1, x1, y2, x2);
            }

            else if (x2 == Contents.board_width)
            {
                testUP = testTren(y1, x1, y2, x2);
                testLEFT = testTrai(y1, x1, y2, x2);
                testBOTTOM = testDuoi(y1, x1, y2, x2);
            }

            else
            {
                testUP = testTren(y1, x1, y2, x2);
                testLEFT = testTrai(y1, x1, y2, x2);
                testBOTTOM = testDuoi(y1, x1, y2, x2);
                testRIGHT = testPhai(y1, x1, y2, x2);
            }
            return (testBOTTOM && testUP && testRIGHT && testLEFT);
        }


        public bool testTren(int y1, int x1, int y2, int x2)
        {
            bool test = true;
            for (int i = x1 - 1; i <= x2 + 1; i++)
            {
                if (Matrix[y1 - 2][i - 1].BackgroundImage != null)
                {
                    test = false;
                    break;
                }
            }

            return test;
        }



        public bool testDuoi(int y1, int x1, int y2, int x2)
        {
            bool test = true;
            for (int i = x1 - 1; i <= x2 + 1; i++)
            {
                if (Matrix[y1][i - 1].BackgroundImage != null)
                {
                    test = false;
                    break;
                }
            }
            return test;
        }

        public bool testTrai(int y1, int x1, int y2, int x2)
        {
            bool test = true;
            for (int i = y1; i <= y2; i++)
            {
                if (Matrix[i - 1][x1 - 2].BackgroundImage != null)
                {
                    test = false;
                }
            }
            return test;
        }

        public bool testPhai(int y1, int x1, int y2, int x2)
        {
            bool test = true;
            for (int i = y1; i <= y2; i++)
            {
                if (Matrix[i - 1][x1].BackgroundImage != null)
                {
                    test = false;
                }
            }
            return test;
        }

        private void Set_Click(object sender, EventArgs e)
        {
            int x, y, a, b;
            string str = System.String.Empty;
            Color color = Color.White;
            if (Type == shiptype.AC)
            {
                color = Color.Red;
                str = "\\Resources\\mau_do.png";
            }
            if (Type == shiptype.Destroyer)
            {
                color = Color.Yellow;
                str = "\\Resources\\mau_vang.png";
            }
            if (Type == shiptype.Cruiser)
            {
                color = Color.Orange;
                str = "\\Resources\\mau_cam.png";
            }
            if (Type == shiptype.LC)
            {
                color = Color.Green;
                str = "\\Resources\\mau_xanh_la.jpg";
            }
            if (Int32.TryParse(TbX1.Text, out x) && Int32.TryParse(TbY1.Text, out y) && Int32.TryParse(TbX2.Text, out a) && Int32.TryParse(TbY2.Text, out b))
            {
                if (x == a && y != b)
                {
                    if ((b - y) == Convert.ToInt32(Type))
                    {
                        //btpush.Enabled = true;
                        if (TestArea(x, y, a, b))
                        {
                            for (int i = y; i <= b; i++)
                            {
                                Matrix[x - 1][i - 1].BackgroundImage = Image.FromFile(Application.StartupPath + str);

                                Matrix[x - 1][i - 1].BackColor = color;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn hãy chọn lại", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn hãy chọn lại", "Thông báo");
                        //btpush.Enabled = false;
                    }
                }
                else if (x != a && y == b)
                {
                    if ((a - x) == Convert.ToInt32(Type))
                    {
                        if (TestArea(x, y, a, b))
                        {
                            for (int i = x; i <= a; i++)
                            {
                                Matrix[i - 1][y - 1].BackgroundImage = Image.FromFile(Application.StartupPath + str);
                                Matrix[i - 1][y - 1].BackColor = color;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn hãy chọn lại", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn hãy chọn lại", "Thông báo");
                    }
                }
                else if (x == a && y == b)
                {
                    if (TestArea(x, y, a, b))
                    {
                        Matrix[x - 1][y - 1].BackgroundImage = Image.FromFile(Application.StartupPath + str);
                        Matrix[x - 1][y - 1].BackColor = color;
                    }
                    else
                    {
                        MessageBox.Show("Bạn hãy chọn lại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn hãy chọn lại", "Thông báo");
                }

                TbX1.Text = null;
                TbX1.Enabled = false;
                TbX2.Text = null;
                TbX2.Enabled = false;
                TbY1.Text = null;
                TbY1.Enabled = false;
                TbY2.Text = null;
                TbY2.Enabled = false;
                Set.Click -= Set_Click;
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn lại", "Thông báo");
                TbX1.Text = null;
                TbX1.Enabled = false;
                TbX2.Text = null;
                TbX2.Enabled = false;
                TbY1.Text = null;
                TbY1.Enabled = false;
                TbY2.Text = null;
                TbY2.Enabled = false;
                Set.Click -= Set_Click;
                SoLuongTau -= 1;
            }
        }



        #endregion
    }
}
