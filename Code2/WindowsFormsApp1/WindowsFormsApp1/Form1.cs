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
            button1.Text = "我被按了";
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.Red;
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Blue;
            button2.Text = "我沒被按";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "我被按了";
            button2.BackColor = Color.Blue;
            button2.ForeColor = Color.Red;
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Blue;
            button1.Text = "我沒被按";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int length = int.Parse(input);
            int square = length * length;
            textBox1.Text = square.ToString();
        }
    }
}
