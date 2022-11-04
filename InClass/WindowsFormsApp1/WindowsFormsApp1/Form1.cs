using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 여기에 ....코드5-35 추가
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 메시지박스 사용 : MessageBox.Show()
            MessageBox.Show("Hello, C# window form");
            string str = textBox1.Text;
            if (str == "") {
                label1.Text = "Hello, everybody";
            } else {
                label1.Text = "Hello, " + str;
                textBox1.Text = "";
            }
           
        }
    }
}
