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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(text_year.Text);
            int m = Convert.ToInt32(text_month.Text);
            int d = Convert.ToInt32(text_day.Text);

          
            int s = y + y / 4 - y / 100 + y / 400 + (int)(2.6 * m + 1.6) + d;
            int r = s % 7;

            if (m == 1 || m ==2)
            {
                y--;
                m++;
            }

            String[] st = new string[7] { "일", "월", "화", "수", "목", "금", "토" };
            lab_out.Text = st[r];
        }

        // double a = 15/2 -> 7이 나온다(15,2둘다 정수로 정수연산을 함)
        // double a = 15.0/2.0 -> 7.5가 나온다

    }
}
