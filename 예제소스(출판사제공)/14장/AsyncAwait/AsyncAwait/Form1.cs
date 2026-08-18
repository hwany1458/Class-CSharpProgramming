using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;

            button1.Click += Button1_Click;
        }

        private async void Button1_Click(object? sender, EventArgs e)
        {
            // 코드 14-8: 비동기 처리 호출
            /* richTextBox1.Text += "이벤트 핸들러 실행\n";
            await Task.Delay(10 * 1000);
            richTextBox1.Text += "이벤트 핸들러 종료\n"; */

            // 코드 14-9: 비동기 처리 구현
            richTextBox1.Text += "이벤트 핸들러 실행\n";
            await AsyncTest1(10 * 1000);
            richTextBox1.Text += "이벤트 핸들러 종료\n";
        }

        private Task AsyncTest(int count)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(count);
            });
        }
    }
}
