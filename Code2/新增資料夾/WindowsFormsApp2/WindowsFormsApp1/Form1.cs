using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool flag = false;
        private DateTime myDateTime;

        public Form1()
        {
            InitializeComponent();

            label4.Text = DateTime.Now.ToString("yyyy年M月d日H時m分s秒");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("yyyy年M月d日H時m分s秒");

            if (flag)
            {
                TimeSpan timeSpan1 = new TimeSpan(DateTime.Now.Ticks);
                TimeSpan timeSpan2 = new TimeSpan(myDateTime.Ticks);
                TimeSpan timeSpan3 = timeSpan2.Subtract(timeSpan1);
                label5.Text = timeSpan3.ToString();

                if (timeSpan3.Seconds < 1)
                {
                    WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();
                    windowsMediaPlayer.URL = @"C:\Users\Public\Music\Sample Music\Kalimba.mp3";
                    windowsMediaPlayer.controls.play();

                    Bitmap bitmap = new Bitmap(@"images\boom.jpg");
                    pictureBox1.Image = bitmap;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDateTime = dateTimePicker1.Value;
            flag = true;
        }
    }
}