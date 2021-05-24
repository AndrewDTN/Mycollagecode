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
        Random rand = new Random();
        int a = 0;
        public Form1()
        {
            a = rand.Next(0, 100);
            InitializeComponent();
            label1.Text = "答案為" + a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (int.TryParse(textBox1.Text, out k) == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }

            int b = int.Parse(textBox1.Text) - a;
            if (b == 0)
            {
                label3.Text = "恭喜答對";
            }
            else if (b <= 10 && b >= -10) 
            {
                label3.Text = "答案接近了";
            }
            else if (b > 10 || b <= -10) 
            {
                label3.Text = "答案差地遠呢";
            }
        }
    }
}
