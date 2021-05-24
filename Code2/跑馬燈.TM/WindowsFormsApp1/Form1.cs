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
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int x = label1.Location.X;
                int y = label1.Location.Y;

                if (x > this.Width) x = -label1.Width;

                label1.Location = new Point(x + 5, y);
            }
            else if (radioButton2.Checked)
            {
                int x = label1.Location.X;
                int y = label1.Location.Y;

                if (y > this.Height) y = -label1.Height;

                label1.Location = new Point(x, y + 5);
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
    }
}
