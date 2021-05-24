using System;//1.循環或隨機播放，2.播放速度調整。
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private int a = -1;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            listBox1.Items.Add(openFileDialog.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1) return;

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;

            string str = listBox1.SelectedItem.ToString();
            Bitmap bitmap = new Bitmap(str);
            pictureBox1.Image = bitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            a = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 0 || count >= listBox1.Items.Count) return;

            string str = listBox1.Items[count].ToString();

            Bitmap bitmap = new Bitmap(str);
            pictureBox1.Image = bitmap;

            count++;
            if (count >= listBox1.Items.Count) count = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            a = 2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count < 0 || count >= listBox1.Items.Count) return;

            Random rand = new Random();
            string str = listBox1.Items[rand.Next(0, listBox1.Items.Count)].ToString();

            Bitmap bitmap = new Bitmap(str);
            pictureBox1.Image = bitmap;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (a == -1) return;
            if (a == 1)
            {
                if (trackBar1.Value == 1) timer1.Interval = 100;
                else if (trackBar1.Value == 2) timer1.Interval = 500;
                else if (trackBar1.Value == 3) timer1.Interval = 1000;
                else if (trackBar1.Value == 4) timer1.Interval = 1500;
                else if (trackBar1.Value == 5) timer1.Interval = 2000;
            }
            else if (a == 2)
            {
                if (trackBar1.Value == 1) timer2.Interval = 100;
                else if (trackBar1.Value == 2) timer2.Interval = 500;
                else if (trackBar1.Value == 3) timer2.Interval = 1000;
                else if (trackBar1.Value == 4) timer2.Interval = 1500;
                else if (trackBar1.Value == 5) timer2.Interval = 2000;
            }
        }
    }
}
