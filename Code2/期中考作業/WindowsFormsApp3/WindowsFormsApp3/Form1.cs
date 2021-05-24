using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            int a = rand.Next(1, 10);
            if (a == 1)
            {
                button1.BackColor = Color.Aqua;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            else if (a == 2)
            {
                button2.BackColor = Color.Aqua;
                button1.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            else if (a == 3)
            {
                button3.BackColor = Color.Aqua;
                button2.BackColor = Color.White;
                button1.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            else if (a == 4)
            {
                button4.BackColor = Color.Aqua;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button1.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            else if (a == 5)
            {
                button5.BackColor = Color.Aqua;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button1.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            else if (a == 6)
            {
                button6.BackColor = Color.Aqua;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button1.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            else if (a == 7)
            {
                button7.BackColor = Color.Aqua;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button1.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            else if (a == 8)
            {
                button8.BackColor = Color.Aqua;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button1.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            else if (a == 9)
            {
                button9.BackColor = Color.Aqua;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button1.BackColor = Color.White;
            }
        }

        private int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Aqua) 
            {
                a++;
                label1.Text = "得分:"+a.ToString();
            }
            else
            {
                a--;
                label1.Text = "得分:" + a.ToString();
            }
        }
    }
}
