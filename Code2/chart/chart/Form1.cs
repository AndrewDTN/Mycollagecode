using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (double x = 0; x <= 6.28; x += 0.1)
            {
                double a = Math.Sin(x);
                chart1.Series[0].Points.AddXY(x, a);
            }
        }
    }
}
