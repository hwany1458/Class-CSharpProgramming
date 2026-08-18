namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            // 코드 14-5: Thread.Sleep()을 포함한 윈도 폼 프로그램
            /* richTextBox1.Text += "이벤트 핸들러 실행\n";
            // 10초 동안 대기합니다(ms 단위이므로 10 * 1000).
            Thread.Sleep(10 * 1000);
            richTextBox1.Text += "이벤트 핸들러 종료\n"; */


            // 코드 14-6: 추가적인 스레드를 사용한 윈도 폼 프로그램(오류 발생)
            /* richTextBox1.Text += "이벤트 핸들러 실행\n";
            new Thread(() =>
            {
                Thread.Sleep(10 * 1000);
                richTextBox1.Text += "이벤트 핸들러 종료\n";
            }).Start(); */


            // 코드 14-7: 추가 스레드와 UI 스레드를 조합한 윈도 폼 프로그램
            richTextBox1.Text += "이벤트 핸들러 실행\n";
            new Thread(() =>
            {
                Thread.Sleep(10 * 1000);
                // richTextBox1을 관리하는 스레드(즉 UI 스레드)에게 코드 실행을 요청합니다.
                richTextBox1.Invoke(() =>
                {
                    richTextBox1.Text += "이벤트 핸들러 종료\n";
                });
            }).Start();
        }
    }
}
