using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap1, bitmap2, bitmap3;
        private int count=0;

        public Form1()
        {
            InitializeComponent();

            bitmap1 = new Bitmap(@"image/0.png");
            bitmap2 = new Bitmap(@"image/1.png");
            bitmap3 = new Bitmap(@"image/2.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = "紅燈";
            label2.Text = "黃燈";
            label3.Text = "綠燈";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count>=0 && count<=2)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                pictureBox1.Image = bitmap1;
                label4.Text = "計時:" + (3-count).ToString();
                count++;
            }
            else if(count==3 || count==5)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Green;
                pictureBox1.Image = bitmap2;
                label4.Text = "計時:" + (6 - count).ToString();
                count++;
            }
            else if(count==4)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Green;
                pictureBox1.Image = bitmap3;
                label4.Text = "計時:" + (6 - count).ToString();
                count++;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Black;
                label4.Text = "計時:";
                count = 0;
            }
        }
    }
}
