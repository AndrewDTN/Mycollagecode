using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Point start;
        private bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;

            start = new Point(e.X, e.Y);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = flag.ToString();

            if (flag)
            {
                int shiftX = e.X - start.X;
                int shiftY = e.Y - start.Y;

                button1.Location = new Point(button1.Location.X + shiftX, button1.Location.Y + shiftY);
            }
        }
    }
}