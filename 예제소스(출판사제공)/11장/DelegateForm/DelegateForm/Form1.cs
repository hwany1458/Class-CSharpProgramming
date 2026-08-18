namespace DelegateForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 버튼을 생성하고 설정합니다.
            // 출력이 이상할 때는 Width와 Height를 적절하게 변경해주세요.
            Button button = new Button();
            button.Text = "버튼";
            button.Width = 100;
            button.Height = 23;
            button.Click += delegate (object? sender, EventArgs args)
            {
                MessageBox.Show("무명 델리게이터를 사용한 이벤트 연결입니다.");
            };
            button.Click += (sender, args) =>
            {
                MessageBox.Show("람다를 사용한 이벤트 연결입니다.");
            };

            // 버튼을 화면에 추가합니다.
            Controls.Add(button);
        }
    }
}
