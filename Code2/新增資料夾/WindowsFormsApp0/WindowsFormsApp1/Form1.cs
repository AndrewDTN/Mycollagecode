using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        private Bitmap bitmap1, bitmap2, bitmap3;

        public Form1()
        {
            InitializeComponent();

            bitmap1 = new Bitmap(@"images/0.png");
            bitmap2 = new Bitmap(@"images/1.png");
            bitmap3 = new Bitmap(@"images/2.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter < 3)
            {
                label4.Text = "計時:" + (3 - counter).ToString();

                pictureBox1.Image = bitmap1;
            }
            else if (counter >= 3 && counter <= 5)
            {
                label4.Text = "計時:" + (6 - counter).ToString();

                if(pictureBox1.Image != bitmap2) pictureBox1.Image = bitmap2;
                else pictureBox1.Image = bitmap3;
            }
            else if (counter == 6) label4.Text = "計時:";

            if (counter == 0)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
            }
            else if (counter == 3)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Green;
            }
            else if (counter == 6)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Black;

                counter = -1;
            }
            counter++;
        }
    }
}