namespace FirstFormApplication
{
    // 코드 5-35
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 숫자를 적절하게 조절해서 사용해주세요.
            int width = 125;
            int height = 23;
            int margin = 6;
            myButton.Text = "코드에서 변경!";
            myButton.Width = width;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
                button.Text = "동적 생성 " + i + "번째";
                button.Width = width;
                button.Height = height;
            }
        }
    }
}
