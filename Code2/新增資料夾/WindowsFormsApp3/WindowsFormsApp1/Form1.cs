using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.Text = "Mouse Left Click";

                Bitmap bitmap = new Bitmap(@"images\left.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (e.Button == MouseButtons.Right)
            {
                label1.Text = "Mouse Right Click";

                Bitmap bitmap = new Bitmap(@"images\right.jpg");
                pictureBox1.Image = bitmap;
            }
        }
    }
}