namespace RadioButtonForm
{
    public partial class Form1 : Form
    {
        // 코드 9-28: 라디오 버튼 생성
        public Form1()
        {
            InitializeComponent();

            // 출력이 깨질 경우 숫자를 적절하게 변경해서 사용해주세요.
            int width = 100;
            int height = 23;
            int margin = 3;
            RadioButton radioButton1 = new RadioButton()
            {
                Text = "감자",
                Width = width,
                Height = height,
                Location = new Point(10, height * 0 + margin)
            };
            RadioButton radioButton2 = new RadioButton()
            {
                Text = "고구마",
                Width = width,
                Height = height,
                Location = new Point(10, height * 1 + margin)
            };
            RadioButton radioButton3 = new RadioButton()
            {
                Text = "토마토",
                Width = width,
                Height = height,
                Location = new Point(10, height * 2 + margin)
            };
            Button button = new Button()
            {
                Text = "클릭",
                Width = width,
                Height = height,
                Location = new Point(10, height * 3 + margin)
            };
            button.Click += ButtonClick;

            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton3);
            Controls.Add(button);
        }

        // 코드 9-29: 라디오 버튼 활용
        private void ButtonClick(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (radioButton.Checked)
                    {
                        MessageBox.Show(radioButton.Text);
                    }
                }
            }
        }
    }
}
