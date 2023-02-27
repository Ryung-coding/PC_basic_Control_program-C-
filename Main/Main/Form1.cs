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
            string a = "hello";
            string b = " Ryung";
            string c = a;
            Console.WriteLine(c);
            Console.WriteLine(c.Length);

            bool t = false; 

            if (t == false)
            {
                Console.WriteLine(c);
            }
        }
    }
}
