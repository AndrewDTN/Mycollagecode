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
            label3.Text = "藍燈";
            label3.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "紅燈";
            label3.ForeColor = Color.Red;
            label1.Text = "藍燈";
            label1.ForeColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "綠燈" || label2.Text == "綠燈" || label3.Text == "綠燈")
            {
                string text = label1.Text;
                Color color = label1.ForeColor;
                label1.Text = label2.Text;
                label1.ForeColor = label2.ForeColor;
                label2.Text = label3.Text;
                label2.ForeColor = label3.ForeColor;
                label3.Text = text;
                label3.ForeColor = color;
            }
            else
            {
                label1.Text = "紅燈";
                label1.ForeColor = Color.Red;
                label2.Text = "綠燈";
                label2.ForeColor = Color.Green;
                label3.Text = "藍燈";
                label3.ForeColor = Color.Blue;
            }
        }
    }
}
