using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bitmap1 = new Bitmap(@"image\left.jpg");
            Bitmap bitmap2 = new Bitmap(@"image\right.jpg");
            if (e.Button == MouseButtons.Left) 
            {
                label1.Text = "left click";
                pictureBox1.Image = bitmap1;
            }
            else
            {
                label1.Text = "right click";
                pictureBox1.Image = bitmap2;
            }
        }
    }
}
