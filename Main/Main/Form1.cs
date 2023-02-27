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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = Convert.ToInt32(msg.Text); //변수형태 고치기
            sec--;

            if (sec < 0)
            {
                sec = 0;
                timer1.Enabled = false; //타이머를 중지
                MessageBox.Show("end"); //MODAL view라고 하는 것으로 이 창 이외는 다 먹통이 된다.
                Application.Exit(); // 프로그램 종료
            }

            msg.Text = sec.ToString(); //Convert말고 이러한 방식으로도 가능하다

        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            btn.Left = rnd.Next(this.Width - btn.Width);//버튼의 좌측상단이 스크린의 왼쪽 벽과의 거리를 의미함 [px]
            btn.Top = rnd.Next(this.Height - btn.Height);//버튼의 좌측상단이 스크린의 왼쪽 벽과의 거리를 의미함 [px]
        }
    }
}
