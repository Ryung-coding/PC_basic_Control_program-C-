using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int x_past, y_past;



        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics grp = pic.CreateGraphics();
                Color col = Color.Black;

                if (rad_red.Checked)
                    col = Color.Red;
                if (rad_blue.Checked)
                    col = Color.Blue;
                if (rad_black.Checked)
                    col = Color.Black;

                //grp.DrawEllipse(new Pen(col), e.X, e.Y, 1, 1);
                grp.DrawLine(new Pen(col), x_past, y_past, e.X, e.Y);
                x_past = e.X;
                y_past = e.Y;
            }
            

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            x_past = e.X;
            y_past = e.Y;   
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }
    }
}
