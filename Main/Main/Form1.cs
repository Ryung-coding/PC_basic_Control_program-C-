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

            double s = y + y/4 - y/100 + y/400 + 2.6*m + 1.6 + d;
            //int s = y + y / 4 - y / 100 + y / 400 + (int)(2.6 * m + 1.6) + d;
            int r = (int)s % 7;
            //int r = s % 7;

            if (m == 1)
            {
                y--;
                m = 13;
            }
            else if( m == 2)
            {
                y--;
                m = 14;
            }

            if (r == 0)
                lab_out.Text = "일";

            if (r == 2)
                lab_out.Text = "화";

            if (r == 3)
                lab_out.Text = "수";

            if (r == 4)
                lab_out.Text = "목";

            if (r == 5)
                lab_out.Text = "금";

            if (r == 6)
                lab_out.Text = "토";

            if (r == 1)
                lab_out.Text = "월";




        }

        // double a = 15/2 -> 7이 나온다(15,2둘다 정수로 정수연산을 함)
        // double a = 15.0/2.0 -> 7.5가 나온다

    }
}
