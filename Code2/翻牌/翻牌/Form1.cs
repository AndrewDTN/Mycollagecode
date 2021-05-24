using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 翻牌
{
    public partial class Form1 : Form
    {
        List<int> PositionList = new List<int>();
        List<Bitmap> BitmapsList = new List<Bitmap>();
        List<PictureBox> PictureBoxList = new List<PictureBox>();
        private int count = 0;
        private int indexOld;
        int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBoxList.Add(pictureBox1);
            PictureBoxList.Add(pictureBox2);
            PictureBoxList.Add(pictureBox3);
            PictureBoxList.Add(pictureBox4);
            PictureBoxList.Add(pictureBox5);
            PictureBoxList.Add(pictureBox6);
            PictureBoxList.Add(pictureBox7);
            PictureBoxList.Add(pictureBox8);

            BitmapsList.Add(new Bitmap(@"images\1.png"));
            BitmapsList.Add(new Bitmap(@"images\2.png"));
            BitmapsList.Add(new Bitmap(@"images\3.png"));
            BitmapsList.Add(new Bitmap(@"images\4.png"));
            BitmapsList.Add(new Bitmap(@"images\卡背.jpg"));

            for (int i = 0; i < 4; i++) PositionList.Add(i);
            for (int i = 0; i < 4; i++) PositionList.Add(i);

            for (int i = 0; i < PositionList.Count; i++)
            {
                PictureBoxList[i].Image = BitmapsList[4];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            int index = 0;
            for (int i = 0; i < PictureBoxList.Count; i++) 
            {
                if (PictureBoxList[i].Name == pictureBox.Name) 
                {
                    index = i;
                    break;
                }
            }
            PictureBoxList[index].Image = BitmapsList[PositionList[index]];
            count++;

            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
          
            if(count==2)
            {
                if(PositionList[index]!=PositionList[indexOld])
                {
                    PictureBoxList[index].Image = BitmapsList[4];
                    PictureBoxList[indexOld].Image = BitmapsList[4];
                    a--;
                    label2.Text = a.ToString();
                }
                if (PositionList[index] == PositionList[indexOld])
                {
                    a++;
                    label2.Text = a.ToString();
                }
                count = 0;
            }
            
            indexOld = index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                PictureBoxList[i].Image = BitmapsList[4];
            }
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PictureBoxList.Count; i++) 
            {
                PictureBoxList[i].Image = BitmapsList[PositionList[i]];
            }
            count = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < PositionList.Count - 1; i++)  
            {
                int index = random.Next(i, PositionList.Count);
                int temp = PositionList[i];
                PositionList[i] = PositionList[index];
                PositionList[index] = temp;
            }
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                if (PictureBoxList[i].Image != BitmapsList[4])
                {
                    PictureBoxList[i].Image = BitmapsList[PositionList[i]];
                }
            }
            if(count == 0)count=0;
            if (count == 1) count = 1;
            if (count == 2) count = 2;
        }
    }
}
