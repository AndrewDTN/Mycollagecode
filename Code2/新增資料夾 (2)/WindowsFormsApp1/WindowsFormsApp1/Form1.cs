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
        private int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            a = int.Parse(numericUpDown1.Value.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a--;
            label3.Text = a.ToString();
            if(a==0)
            {
                MessageBox.Show("時間到了");
            }
            else if(a<0)
            {
                label3.Text = "0";
            }
        }
    }
}
