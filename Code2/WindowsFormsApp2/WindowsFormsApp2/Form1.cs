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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int ans = a + b;
                label4.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("輸入不可為空白");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //全除錯完成
            if(textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("輸入不可為空白");
                return;
            }

            int a,b;
            bool ok = int.TryParse(textBox1.Text, out a);
            if(ok==false)
            {
                MessageBox.Show("輸入不可為非數字");
                return;
            }
            ok = int.TryParse(textBox2.Text, out b);
            if (ok == false)
            {
                MessageBox.Show("輸入不可為非數字");
                return;
            }

            //int a = int.Parse(textBox1.Text);
            //int b = int.Parse(textBox2.Text);
            int ans = a - b;
            label4.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int ans = a * b;
            label4.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox1.Text);
            double b = int.Parse(textBox2.Text);
            double ans = a / b;
            label4.Text = ans.ToString();
        }
    }
}
