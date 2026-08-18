namespace GroupBoxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 출력이 깨질 경우 숫자를 적절하게 변경해서 사용해주세요.
            int width = 100;
            int height = 23;
            int margin = 3;

            // 코드 9-31: 그룹 박스 생성
            // 라디오 버튼을 생성합니다.
            // 위치와 크기 지정이 약간 복잡해보일 수 있는데
            // 이것저것 입력하면서 예뻐보이는 값을 넣었습니다.
            GroupBox groupBox1 = new GroupBox()
            {
                Text = "식물",
                Location = new Point(margin, margin),
                Size = new Size(width + margin * 2, height * 3 + margin * 2)
            };
            GroupBox groupBox2 = new GroupBox()
            {
                Text = "물고기",
                Location = new Point(width + margin * 5, margin),
                Size = new Size(width + margin * 2, height * 3 + margin * 2)
            };
            
            // 코드 9-30: 라디오 박스 생성
            RadioButton radioButton1 = new RadioButton()
            {
                Text = "감자",
                Width = width,
                Height = height,
                Location = new Point(margin, height * 1 + margin)
            };
            RadioButton radioButton2 = new RadioButton()
            {
                Text = "고구마",
                Width = width,
                Height = height,
                Location = new Point(margin, height * 2 + margin)
            };
            RadioButton radioButton3 = new RadioButton()
            {
                Text = "광어",
                Width = width,
                Height = height,
                Location = new Point(margin, height * 1 + margin)
            };
            RadioButton radioButton4 = new RadioButton()
            {
                Text = "우럭",
                Width = width,
                Height = height,
                Location = new Point(margin, height * 2 + margin)
            };
            Button button = new Button()
            {
                Text = "클릭",
                Width = width,
                Height = height,
                Location = new Point(margin, height * 3 + margin * 4)
            };

            // 이벤트를 연결합니다.
            button.Click += ButtonClick;

            // 라디오 버튼을 그룹 박스에 추가합니다.
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);

            // 요소를 화면에 추가합니다.
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(button);
        }

        // 코드 9-32: 그룹 박스와 라디오 버튼 활용
        private void ButtonClick(object? sender, EventArgs e)
        {
            foreach (var outerItem in Controls)
            {
                if (outerItem is GroupBox)
                {
                    foreach(var innerItem in ((GroupBox)outerItem).Controls)
                    {
                        RadioButton radioButton = innerItem as RadioButton;
                        if(radioButton != null && radioButton.Checked)
                        {
                            MessageBox.Show(radioButton.Text);
                        }
                    }
                }
            }
        }
    }
}
