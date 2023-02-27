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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.MaxValue; //int.이란 int라는 클래스의 함수를 실행한다는 뜻 이 코드는 최대값을 넣는 경우
            a++; //하나의 값을 증가시킴
            Console.WriteLine(a); // 그 경우, 가장 최소값으로 반전이 됨
            
        }
    }
}
