using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_One_21100112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = 0;
            number.Text = Convert.ToString(n);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            number.Text = Convert.ToString(n);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Reset_MouseDown(object sender, MouseEventArgs e)
        {
            Reset.BackColor = Color.Gray;
        }

        private void Reset_MouseUp(object sender, MouseEventArgs e)
        {
            Reset.BackColor = Color.White;
        }

        private void Add_MouseDown(object sender, MouseEventArgs e)
        {
            Add.BackColor= Color.Gray;
        }

        private void Add_MouseUp(object sender, MouseEventArgs e)
        {
            Add.BackColor = Color.White;
        }
    }
}
