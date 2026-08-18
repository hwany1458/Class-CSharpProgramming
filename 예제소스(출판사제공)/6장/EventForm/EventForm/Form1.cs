namespace EventForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 코드 6-42: 자동 생성된 이벤트 메서드
            button1.Click += Button1_Click;

            // 코드 6-44: FormClosed 이벤트
            FormClosed += Form1_FormClosed;
        }

        // 코드 6-44: FormClosed 이벤트
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        // 코드 6-42: 자동 생성된 이벤트 메서드
        private void Button1_Click(object? sender, EventArgs e)
        {
            // throw new NotImplementedException();
            
            // 코드 6-43: sender 객체 활용
            Button self = (Button)sender;
            self.Text = "저를 클릭했습니다!";
        }

        // 코드 6-39: 자동으로 생성된 이벤트 메서드
        // 코드 6-40: button1_Click() 메서드
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            label1.Text += "+";
        }

        // 코드 6-46: 시간 경과 확인 코드
        private int elapsedTime = 0;
        // 코드 6-45: Tick 이벤트의 이벤트 메서드
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 코드 6-46: 시간 경과 확인 코드
            elapsedTime++;
            textBox1.Text = elapsedTime + "초 경과";
            label1.Text = elapsedTime + "초 경과";
        }
    }
}
