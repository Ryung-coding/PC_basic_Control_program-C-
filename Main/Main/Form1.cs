using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Main
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NumToBit_Click(object sender, EventArgs e)
        {
            int number_data = Convert.ToInt32(txtNumber.Text);

            chk0.Checked = (number_data & (0x01 << 0)) != 0;
            chk1.Checked = (number_data & (0x01 << 1)) != 0;
            chk2.Checked = (number_data & (0x01 << 2)) != 0;
            chk3.Checked = (number_data & (0x01 << 3)) != 0;
            chk4.Checked = (number_data & (0x01 << 4)) != 0;
            chk5.Checked = (number_data & (0x01 << 5)) != 0;
            chk6.Checked = (number_data & (0x01 << 6)) != 0;
            chk7.Checked = (number_data & (0x01 << 7)) != 0;

            //txtNumber.Text = "";
        }

        private void BitToNum_Click(object sender, EventArgs e)
        {
            int temp0 = chk0.Checked ? 1 : 0;
            int temp1 = chk1.Checked ? 2 : 0;
            int temp2 = chk2.Checked ? 4 : 0;
            int temp3 = chk3.Checked ? 8 : 0;
            int temp4 = chk4.Checked ? 16 : 0;
            int temp5 = chk5.Checked ? 32 : 0;
            int temp6 = chk6.Checked ? 64 : 0;

            int total = temp0 + temp1 + temp2 + temp3 + temp4 + temp5 + temp6;

            txtNumber.Text = total.ToString();



        }

        private void Reset_Click(object sender, EventArgs e)
        {
            chk0.Checked = false;
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;
            chk6.Checked = false;
            chk7.Checked = false;
        }


        private void ON_Click(object sender, EventArgs e)
        {
            int BIT = Convert.ToInt32(txtIndex.Text);

            chk0.Checked = BIT == 0 ? true : chk0.Checked;
            chk1.Checked = BIT == 1 ? true : chk1.Checked;
            chk2.Checked = BIT == 2 ? true : chk2.Checked;
            chk3.Checked = BIT == 3 ? true : chk3.Checked;
            chk4.Checked = BIT == 4 ? true : chk4.Checked;
            chk5.Checked = BIT == 5 ? true : chk5.Checked;
            chk6.Checked = BIT == 6 ? true : chk6.Checked;
            chk7.Checked = BIT == 7 ? true : chk7.Checked;

            int temp0 = chk0.Checked ? 1 : 0;
            int temp1 = chk1.Checked ? 2 : 0;
            int temp2 = chk2.Checked ? 4 : 0;
            int temp3 = chk3.Checked ? 8 : 0;
            int temp4 = chk4.Checked ? 16 : 0;
            int temp5 = chk5.Checked ? 32 : 0;
            int temp6 = chk6.Checked ? 64 : 0;

            int total = temp0 + temp1 + temp2 + temp3 + temp4 + temp5 + temp6;

            txtNumber.Text = total.ToString();

        }

        private void OFF_Click(object sender, EventArgs e)
        {
            int BIT = Convert.ToInt32(txtIndex.Text);

            chk0.Checked = BIT == 0 ? false : chk0.Checked;
            chk1.Checked = BIT == 1 ? false : chk1.Checked;
            chk2.Checked = BIT == 2 ? false : chk2.Checked;
            chk3.Checked = BIT == 3 ? false : chk3.Checked;
            chk4.Checked = BIT == 4 ? false : chk4.Checked;
            chk5.Checked = BIT == 5 ? false : chk5.Checked;
            chk6.Checked = BIT == 6 ? false : chk6.Checked;
            chk7.Checked = BIT == 7 ? false : chk7.Checked;

            int temp0 = chk0.Checked ? 1 : 0;
            int temp1 = chk1.Checked ? 2 : 0;
            int temp2 = chk2.Checked ? 4 : 0;
            int temp3 = chk3.Checked ? 8 : 0;
            int temp4 = chk4.Checked ? 16 : 0;
            int temp5 = chk5.Checked ? 32 : 0;
            int temp6 = chk6.Checked ? 64 : 0;

            int total = temp0 + temp1 + temp2 + temp3 + temp4 + temp5 + temp6;

            txtNumber.Text = total.ToString();

        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            int number_data = Convert.ToInt32(txtNumber.Text);

            number_data = ~number_data;

            chk0.Checked = (number_data & (0x01 << 0)) != 0;
            chk1.Checked = (number_data & (0x01 << 1)) != 0;
            chk2.Checked = (number_data & (0x01 << 2)) != 0;
            chk3.Checked = (number_data & (0x01 << 3)) != 0;
            chk4.Checked = (number_data & (0x01 << 4)) != 0;
            chk5.Checked = (number_data & (0x01 << 5)) != 0;
            chk6.Checked = (number_data & (0x01 << 6)) != 0;
            chk7.Checked = (number_data & (0x01 << 7)) != 0;

            txtNumber.Text = number_data.ToString();

        }

        private void htnShiftDown_Click(object sender, EventArgs e)
        {
            int number_data = Convert.ToInt32(txtNumber.Text);

            number_data = number_data >> 1;

            chk0.Checked = (number_data & (0x01 << 0)) != 0;
            chk1.Checked = (number_data & (0x01 << 1)) != 0;
            chk2.Checked = (number_data & (0x01 << 2)) != 0;
            chk3.Checked = (number_data & (0x01 << 3)) != 0;
            chk4.Checked = (number_data & (0x01 << 4)) != 0;
            chk5.Checked = (number_data & (0x01 << 5)) != 0;
            chk6.Checked = (number_data & (0x01 << 6)) != 0;
            chk7.Checked = (number_data & (0x01 << 7)) != 0;

            txtNumber.Text = number_data.ToString();
        }

        private void htnShiftUp_Click(object sender, EventArgs e)
        {
            int number_data = Convert.ToInt32(txtNumber.Text);

            number_data = number_data << 1;

            chk0.Checked = (number_data & (0x01 << 0)) != 0;
            chk1.Checked = (number_data & (0x01 << 1)) != 0;
            chk2.Checked = (number_data & (0x01 << 2)) != 0;
            chk3.Checked = (number_data & (0x01 << 3)) != 0;
            chk4.Checked = (number_data & (0x01 << 4)) != 0;
            chk5.Checked = (number_data & (0x01 << 5)) != 0;
            chk6.Checked = (number_data & (0x01 << 6)) != 0;
            chk7.Checked = (number_data & (0x01 << 7)) != 0;

            txtNumber.Text = number_data.ToString();
        }
    }
}
