using System;//1.開始、停止 2.跑法(至少4種) 3.特效(至少2種) 4.設定速度
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int x = label1.Location.X;
                int y = label1.Location.Y;
                if (x > this.Width) x = -label1.Width;
                label1.Location = new Point(x + 5, y);
            }
            else if (radioButton1.Checked)
            {
                int x = label1.Location.X;
                int y = label1.Location.Y;
                if (y > this.Height) y = -label1.Height;
                label1.Location = new Point(x, y + 5);
            }
            else if(radioButton3.Checked)
            {
                int x = label1.Location.X;
                int y = label1.Location.Y;
                if (x<this.Width - 220 && y<this.Height - 80 && c == 0)
                {
                    label1.Location = new Point(x + 5, y);
                }
                else if(x>=this.Width-220 && y<this.Height-80)
                {
                    label1.Location = new Point(x, y + 5);
                }
                else if (x >= 12 && y >= this.Height - 80)
                {
                    label1.Location = new Point(x - 5,y);
                }
                else if (x < this.Width - 220 && y >= 9)
                {
                    label1.Location = new Point(x, y - 5);
                    if (y > 15) c = 1;
                    else if(y <= 15) c = 0;
                }
                //x = this.Width-220;
                //y = this.Height-80; 
            }
            else if(radioButton4.Checked)
            {
                int x = label1.Location.X;
                int y = label1.Location.Y;
                if (x < -this.Width) x = this.Width;
                label1.Location = new Point(x - 5, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        { 
            if(i==0)
            {
                button3.Text = "變回去";
                label1.ForeColor = Color.Aqua;
                i = -1;
            }
            else
            {
                button3.Text = "改顏色";
                label1.ForeColor = Color.Black;
                i = 0;
            }
        }

        int j = 0;
        int k = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                button4.Text = "STOP";
                timer2.Enabled = true;
                k = 1;
            }
            else
            {
                button4.Text = "閃爍";
                timer2.Enabled = false;
                k = 0;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(j==0)
            {
                label1.Text = "";
                j = 1;
            }
            else
            {
                label1.Text = "國立金門大學";
                j = 0;
            }
        }

        int s = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            
            if (s==0)
            {
                timer1.Interval = 30;
                s = 1;
            }
            else if(s==1)
            {
                timer1.Interval = 10;
                s = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (timer1.Interval == 10) timer1.Interval = 30;
            else if (timer1.Interval == 30) timer1.Interval = 50;
        }
    }
}
