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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            label1.Text = rand.Next(1, 6) + "點";
            label2.Text = rand.Next(1, 6) + "點";
            label3.Text = rand.Next(1, 6) + "點";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label1.ForeColor = Color.Red;
            //label2.ForeColor = Color.Green;
            //label3.ForeColor = Color.Blue;

            Random rand = new Random();

            label1.ForeColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            label2.ForeColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            label3.ForeColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }
    }
}
