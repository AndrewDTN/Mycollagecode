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
        private DateTime mydateTime;
        private bool flag = false;

        public Form1()
        {
            InitializeComponent();

            label2.Text = DateTime.Now.ToString("yyyy年M月d日 H時m分s秒");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy年M月d日 H時m分s秒");

            
            if(flag==true)
            {
                TimeSpan timeSpan1 = new TimeSpan(mydateTime.Ticks);
                TimeSpan timeSpan2 = new TimeSpan(DateTime.Now.Ticks);
                TimeSpan timeSpan3 = timeSpan1.Subtract(timeSpan2);
                label5.Text = timeSpan3.ToString();
                if(timeSpan3.Seconds<1)
                {
                    flag = false;
                    Bitmap bitmap = new Bitmap(@"image\boom.jpg");
                    MessageBox.Show("TIME IS UP");
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            mydateTime = dateTimePicker1.Value;
        }
    }
}
