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
    }
}
