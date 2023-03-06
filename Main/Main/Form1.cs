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
        // double a = 15/2 -> 7이 나온다(15,2둘다 정수로 정수연산을 함)
        // double a = 15.0/2.0 -> 7.5가 나온다

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[10]; //a가 스텍이 생기고 힙에 연결됨
            a[0] = 100; //힙에 100들어감
            int[] b = a; // b가 스텍에 생기고, a가 가르킨 주소값을 동일하게 b도 가르키게 함
            //그러므로 b의 원소와 a의 원소는 따로 다시 안넣어도 바뀜
            b[0]++; //b0의 처음 원소를 바꿨기에 a[0]도 같이 바뀜
            //a는 참조변수이기에 포인터와 다르다!

            //만일 int[] b = new int[10] 이고
            //b = a;
            //b[0]++;
            //라고 할때, b의 메모리를 굳이 잡았기에 비효율적이다.    
            
            //자동 작다 빠르다 -> 스택(Stack) [가비지컬렉터가 알아서 메모리 처리]
            //수동 크다 느리다 -> 힙(Heap)
        }
    }
}
