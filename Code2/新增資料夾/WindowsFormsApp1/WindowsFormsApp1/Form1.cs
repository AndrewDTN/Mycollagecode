using System;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int counter = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            label2.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Enabled = false;

                //MessageBox.Show("OK");

                /*SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = @"C:\Windows\Media\chimes.wav";
                soundPlayer.Play();*/

                WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
                wplayer.URL = @"C:\Windows\Media\flourish.mid";
                wplayer.controls.play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = int.Parse(numericUpDown1.Value.ToString());
            timer1.Enabled = true;
        }
    }
}