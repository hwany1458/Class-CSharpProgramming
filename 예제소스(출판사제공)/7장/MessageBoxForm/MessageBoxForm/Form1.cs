namespace MessageBoxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 코드 7-37: MessageBox 클래스의 Show() 메서드
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            // MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);

            // 코드 7-38: 메시지 상자 활용
            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
        }
    }
}
