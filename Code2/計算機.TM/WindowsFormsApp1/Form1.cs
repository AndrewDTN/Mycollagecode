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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            /*if (button.Name == "button1") input += "1";
            else if (button.Name == "button2") input += "2";
            else if (button.Name == "button3") input += "3";*/
            input += button.Text;
            textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (input.Length <= 0) return;

            input = input.Remove(input.Length - 1, 1);
            textBox1.Text = input;
        }
    }
}
