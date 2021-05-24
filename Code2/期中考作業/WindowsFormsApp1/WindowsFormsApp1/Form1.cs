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
            label1.Text = "紅燈";
            label1.ForeColor = Color.Red;
            label2.Text = "綠燈";
            label2.ForeColor = Color.Green;
            label3.Text = "藍燈";
            label3.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "紅燈";
            label3.ForeColor = Color.Red;
            label2.Text = "綠燈";
            label2.ForeColor = Color.Green;
            label1.Text = "藍燈";
            label1.ForeColor = Color.Blue;
        }

        private int a = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            if(a==0)
            {
                label1.Text = "紅燈";
                label1.ForeColor = Color.Red;
                label2.Text = "綠燈";
                label2.ForeColor = Color.Green;
                label3.Text = "藍燈";
                label3.ForeColor = Color.Blue;
                a++;
            }
            else if(a==1)
            {
                label2.Text = "紅燈";
                label2.ForeColor = Color.Red;
                label3.Text = "綠燈";
                label3.ForeColor = Color.Green;
                label1.Text = "藍燈";
                label1.ForeColor = Color.Blue;
                a++;
            }
            else if(a==2)
            {
                label3.Text = "紅燈";
                label3.ForeColor = Color.Red;
                label1.Text = "綠燈";
                label1.ForeColor = Color.Green;
                label2.Text = "藍燈";
                label2.ForeColor = Color.Blue;
                a=0;
            }
        }
    }
}
