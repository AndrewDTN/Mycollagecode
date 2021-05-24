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
        private string input = "";
        double a = 0;
        double b = 0;
        int c = 0;
        int d = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)/*num*/
        {
            if (c == -1)
            {
                Button button = (Button)sender;
                input += button.Text;
                textBox1.Text = input;
                input = "";
                textBox1.Clear();
                /*label1.Text = "";*/
                c = 0;
                a = 0;
                b = 0;
                d = 0;
            }
            else
            {
                Button button = (Button)sender;
                input += button.Text;
                textBox1.Text = input;
            }
        }
        private void button16_Click(object sender, EventArgs e)/*back*/
        {
            if (input.Length <= 0) return;
            else input = input.Remove(input.Length - 1, 1);
            textBox1.Text = input;
        }

        private void button14_Click(object sender, EventArgs e)/*+*/
        {
            if (input.Length <= 0) return;
            /*label1.Text += "+" + textBox1.Text;*/
            a = int.Parse(textBox1.Text);
            input = "";
            b += a;
            textBox1.Text = b.ToString();
            c = 1;
            d = 1;
        }

        private void button11_Click(object sender, EventArgs e)/*=*/
        {
            if (c == 1)
            {
                /*label1.Text += "+" + textBox1.Text;*/
                a = int.Parse(textBox1.Text);
                b += a;
                textBox1.Text = b.ToString();
                c = -1;
            }
            else if(c == 2)
            {
                /*label1.Text += "-" + textBox1.Text;*/
                a = int.Parse(textBox1.Text);
                b -= a;
                textBox1.Text = b.ToString();
                c = -1;
            }
            else if (c == 3)
            {
                /*label1.Text += "*" + textBox1.Text;*/
                a = int.Parse(textBox1.Text);
                if (b == 0) b = a;
                else b *= a;
                textBox1.Text = b.ToString();
                c = -1;
            }
            else if (c == 4)
            {
                /*label1.Text += textBox1.Text + "/";*/
                a = double.Parse(textBox1.Text);
                input = "";
                if (b == 0) b = a;
                else b /= a;
                textBox1.Text = b.ToString();
                c = -1;
            }
        }

        private void button15_Click(object sender, EventArgs e)/*-*/
        {
            if (input.Length <= 0) return;
            /*label1.Text += textBox1.Text + "-";*/
            a = int.Parse(textBox1.Text);
            input = "";
            textBox1.Clear();
            if (d == 0)
            {
                b = a;
                d = 1;
            }
            else b -= a;
            c = 2;
            textBox1.Text = b.ToString();
        }

        private void button12_Click(object sender, EventArgs e)/***/
        {
            if (input.Length <= 0) return;
            /*label1.Text += "*" + textBox1.Text;*/
            a = int.Parse(textBox1.Text);
            input = "";
            if (b == 0) b = a;
            else b *= a;
            textBox1.Text = b.ToString();
            c = 3;
            d = 1;
        }

        private void button13_Click(object sender, EventArgs e)/*/*/
        {
            if (input.Length <= 0) return;
            /*label1.Text += "/" + textBox1.Text;*/
            a = int.Parse(textBox1.Text);
            input = "";
            if (b == 0) b = a;
            else b /= a;
            textBox1.Text = b.ToString();
            c = 4;
            d = 1;
        }
    }
}
