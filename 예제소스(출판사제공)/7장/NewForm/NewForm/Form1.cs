namespace NewForm
{
    // 코드 7-40: Form 클래스 상속
    public partial class Form1 : Form
    {
        // 코드 7-41: 새로 생성한 CustomForm 클래스의 모양 지정
        class CustomForm : Form
        {
            public CustomForm()
            {
                this.Size = new Size(400, 300);
                Text = "제목 글자";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            
            // 코드 7-42: Show() 메서드
            form.Show();

            // 코드 7-43: ShowDialog() 메서드
            // form.ShowDialog();
        }
    }
}
