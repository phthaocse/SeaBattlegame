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
    public partial class ScreenGame : Form
    {
        public ScreenGame()
        {
            InitializeComponent();
        }

        public class NamePlayer
        {
            static public string name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NamePlayer.name = textBox1.Text;
            SeaBattle f = new SeaBattle();
            this.Hide();
            
            f.ShowDialog();
            this.Close();
        }
    }
}
