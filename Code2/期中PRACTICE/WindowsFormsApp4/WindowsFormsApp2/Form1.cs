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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int a = rand.Next(1, 6);
            int b = rand.Next(1, 6);
            int c = rand.Next(1, 6);
            label1.Text = a + "點";
            label2.Text = b + "點";
            label3.Text = c + "點";
            int t = a + b + c;
            string total = t.ToString();
            MessageBox.Show("總共為" + total + "點");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int a = rand.Next(1, 6);
            int b = rand.Next(1, 6);
            int c = rand.Next(1, 6);
            label1.Text = a + "點";
            label2.Text = b + "點";
            label3.Text = c + "點";
            if (a == b && b == c) MessageBox.Show("豹子");
            else if (a != b && a != c && b != c) MessageBox.Show("沒有點數");
            else
            {
                if (a == b) MessageBox.Show(c + "點");
                else if (b == c) MessageBox.Show(a + "點");
                else if(a == c) MessageBox.Show(b + "點");
            }
        }
    }
}
