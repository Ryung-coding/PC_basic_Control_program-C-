using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncing_Ball_21100112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool flag_x = true , flag_y = false ;
        int dx = 7, dy = 7;
        int past_distance2 = 0, now_distance2 = 0;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dx = 3;
            dy = 3;
        }

        private void pictureBox1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dx = 20;
            dy = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Width + pictureBox1.Left > this.Width   || pictureBox1.Left< 0)
                flag_x = !flag_x;

            if (pictureBox1.Height + pictureBox1.Top > this.Height || pictureBox1.Top< 0)
                flag_y = !flag_y;


            if (flag_x)
                pictureBox1.Left += dx;
            else
                pictureBox1.Left -= dx;

            if(flag_y)
                pictureBox1.Top += dy;
            else
                pictureBox1.Top -= dy;

            now_distance2 = pictureBox1.Left*pictureBox1.Left + pictureBox1.Top* pictureBox1.Top;

            if(now_distance2 < past_distance2)
                pictureBox1.BackColor = Color.Red;
            else
                pictureBox1.BackColor = Color.Blue;

            past_distance2 = now_distance2;

        }

    }
}
