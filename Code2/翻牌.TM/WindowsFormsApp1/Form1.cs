using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int count;
        private int indexOld;

        List<int> PositionList = new List<int>();
        List<Bitmap> BitmapsList = new List<Bitmap>();
        List<PictureBox> PictureBoxList = new List<PictureBox>();

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

            BitmapsList.Add(new Bitmap(@"images\Tarot.jpeg"));
            BitmapsList.Add(new Bitmap(@"images\1.jpg"));
            BitmapsList.Add(new Bitmap(@"images\2.jpg"));
            BitmapsList.Add(new Bitmap(@"images\3.jpg"));

            for (int i = 0; i < 3; i++) PositionList.Add(i+1);
            for (int i = 0; i < 3; i++) PositionList.Add(i+1);

            for (int i = 0; i < PictureBoxList.Count; i++)
            //foreach(PictureBox pictureBox in PictureBoxList)
            {
                PictureBoxList[i].Image = BitmapsList[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                PictureBoxList[i].Image = BitmapsList[PositionList[i]];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                PictureBoxList[i].Image = BitmapsList[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for(int i=0;i< PositionList.Count - 1; i++)
            {
                int index = rand.Next(i + 1, PositionList.Count - 1);
                int temp = PositionList[i];
                PositionList[i] = PositionList[index];
                PositionList[index] = temp;
            }

            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                PictureBoxList[i].Image = BitmapsList[PositionList[i]];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            int index = 0;
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                if (pictureBox.Name == PictureBoxList[i].Name)
                {
                    index = i;
                    break;
                }
            }

            PictureBoxList[index].Image = BitmapsList[PositionList[index]];
            count++;

            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            if (count == 2)
            {
                if (PositionList[index] != PositionList[indexOld])
                {
                    PictureBoxList[indexOld].Image = BitmapsList[0];
                    PictureBoxList[index].Image = BitmapsList[0];
                }
                if (PositionList[index] == PositionList[indexOld])
                {
                    // 加分
                }
                count = 0;
            }

            indexOld = index;
        }
    }
}
