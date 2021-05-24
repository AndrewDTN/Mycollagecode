using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Bitmap seassor =new Bitmap(@"images/剪刀.jpg");
        Bitmap papper = new Bitmap(@"images/布.jpg");
        Bitmap stone = new Bitmap(@"images/石頭.jpg");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = random.Next(0, 3);
            if (i == 0) pictureBox1.Image = seassor;
            else if (i == 1) pictureBox1.Image = stone;
            else if (i == 2)pictureBox1.Image = papper;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = seassor;
            timer1.Enabled = false;
            if (pictureBox1.Image == seassor) label1.Text = "平手";
            else if (pictureBox1.Image == papper) label1.Text = "你贏了";
            else if (pictureBox1.Image == stone) label1.Text = "你輸了";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = stone;
            timer1.Enabled = false;
            if (pictureBox1.Image == seassor) label1.Text = "你贏了";
            else if (pictureBox1.Image == papper) label1.Text = "你輸了";
            else if (pictureBox1.Image == stone) label1.Text = "平手";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = papper;
            timer1.Enabled = false;
            if (pictureBox1.Image == seassor) label1.Text = "你輸了";
            else if (pictureBox1.Image == papper) label1.Text = "平手";
            else if (pictureBox1.Image == stone) label1.Text = "你贏了";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            timer1.Enabled = true;
            label1.Text = null;
        }
    }
}
