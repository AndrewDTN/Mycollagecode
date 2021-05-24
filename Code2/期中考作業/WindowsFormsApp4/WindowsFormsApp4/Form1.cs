using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton6.Checked == true) label1.Text = "290";
            else if (radioButton1.Checked == true && radioButton7.Checked == true) label1.Text = "350";
            else if (radioButton1.Checked == true && radioButton8.Checked == true) label1.Text = "300";
            else if (radioButton1.Checked == true && radioButton9.Checked == true) label1.Text = "360";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && radioButton6.Checked == true) label1.Text = "270";
            else if (radioButton2.Checked == true && radioButton7.Checked == true) label1.Text = "330";
            else if (radioButton2.Checked == true && radioButton8.Checked == true) label1.Text = "280";
            else if (radioButton2.Checked == true && radioButton9.Checked == true) label1.Text = "340";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true && radioButton6.Checked == true) label1.Text = "230";
            else if (radioButton3.Checked == true && radioButton7.Checked == true) label1.Text = "290";
            else if (radioButton3.Checked == true && radioButton8.Checked == true) label1.Text = "240";
            else if (radioButton3.Checked == true && radioButton9.Checked == true) label1.Text = "300";
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true && radioButton6.Checked == true) label1.Text = "270";
            else if (radioButton4.Checked == true && radioButton7.Checked == true) label1.Text = "330";
            else if (radioButton4.Checked == true && radioButton8.Checked == true) label1.Text = "280";
            else if (radioButton4.Checked == true && radioButton9.Checked == true) label1.Text = "340";
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true && radioButton6.Checked == true) label1.Text = "145";
            else if (radioButton5.Checked == true && radioButton7.Checked == true) label1.Text = "175";
            else if (radioButton5.Checked == true && radioButton8.Checked == true) label1.Text = "150";
            else if (radioButton5.Checked == true && radioButton9.Checked == true) label1.Text = "180";
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton6.Checked == true) label1.Text = "290";
            if (radioButton2.Checked == true && radioButton6.Checked == true) label1.Text = "270";
            if (radioButton3.Checked == true && radioButton6.Checked == true) label1.Text = "230";
            if (radioButton4.Checked == true && radioButton6.Checked == true) label1.Text = "270";
            if (radioButton5.Checked == true && radioButton6.Checked == true) label1.Text = "145";
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton7.Checked == true) label1.Text = "350";
            if (radioButton2.Checked == true && radioButton7.Checked == true) label1.Text = "330";
            if (radioButton3.Checked == true && radioButton7.Checked == true) label1.Text = "290";
            if (radioButton4.Checked == true && radioButton7.Checked == true) label1.Text = "330";
            if (radioButton5.Checked == true && radioButton7.Checked == true) label1.Text = "175";
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton8.Checked == true) label1.Text = "300";
            if (radioButton2.Checked == true && radioButton8.Checked == true) label1.Text = "280";
            if (radioButton3.Checked == true && radioButton8.Checked == true) label1.Text = "240";
            if (radioButton4.Checked == true && radioButton8.Checked == true) label1.Text = "280";
            if (radioButton5.Checked == true && radioButton8.Checked == true) label1.Text = "150";
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton9.Checked == true) label1.Text = "360";
            if (radioButton2.Checked == true && radioButton9.Checked == true) label1.Text = "340";
            if (radioButton3.Checked == true && radioButton9.Checked == true) label1.Text = "300";
            if (radioButton4.Checked == true && radioButton9.Checked == true) label1.Text = "340";
            if (radioButton5.Checked == true && radioButton9.Checked == true) label1.Text = "180";
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label1.Text);
            int b = a + 30;
            label1.Text = b.ToString();
            if(checkBox1.Checked==false)
            {
                b = a - 30;
                label1.Text = b.ToString();
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label1.Text);
            int b = a + 50;
            label1.Text = b.ToString();
            if (checkBox2.Checked == false)
            {
                b = a - 50;
                label1.Text = b.ToString();
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label1.Text);
            int b = a + 100;
            label1.Text = b.ToString();
            if (checkBox3.Checked == false)
            {
                b = a - 100;
                label1.Text = b.ToString();
            }
        }
    }
}
