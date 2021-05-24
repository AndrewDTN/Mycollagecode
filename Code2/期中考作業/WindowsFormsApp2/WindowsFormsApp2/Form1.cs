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
            int k = 0;
            if (int.TryParse(textBox1.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            if (int.TryParse(textBox2.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            if (int.TryParse(textBox3.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            if (int.TryParse(textBox4.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }

            int x = int.Parse(textBox1.Text);
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            int c = int.Parse(textBox4.Text);
            int y = a * x * x * x + b * x * x + c;
            MessageBox.Show(y.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (int.TryParse(textBox8.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            if (int.TryParse(textBox7.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            if (int.TryParse(textBox6.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            if (int.TryParse(textBox5.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }

            int x =int.Parse(textBox8.Text);
            int a = int.Parse(textBox7.Text);
            int b = int.Parse(textBox6.Text);
            int c = int.Parse(textBox5.Text);
            int fir = a * x * x * x - b * x * x;
            if (fir < 0) fir = -fir;
            double d = Math.Pow(x, 0.5);
            double back = c * d;
            double y = fir + back;
            MessageBox.Show(y.ToString());
        }
    }
}
