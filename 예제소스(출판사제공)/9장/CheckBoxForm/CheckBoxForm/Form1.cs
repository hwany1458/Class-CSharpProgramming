namespace CheckBoxForm
{
    public partial class Form1 : Form
    {
        // 코드 9-26: 체크 박스 생성
        class CustomForm : Form
        {
            public CustomForm()
            {
                this.Size = new Size(400, 300);
                this.Text = "제목 글자";
            }
        }

        public Form1()
        {
            InitializeComponent();

            // 출력이 깨질 경우 숫자를 적절하게 변경해서 사용해주세요.
            int width = 100;
            int height = 23;
            int margin = 3;
            CheckBox checkBox1 = new CheckBox()
            {
                Text = "감자",
                Width = width,
                Height = height,
                Location = new Point(10, height * 0 + margin)
            };
            CheckBox checkBox2 = new CheckBox()
            {
                Text = "고구마",
                Width = width,
                Height = height,
                Location = new Point(10, height * 1 + margin)
            };
            CheckBox checkBox3 = new CheckBox()
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

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(button);
        }

        // 코드 9-27: 체크 박스 활용
        private void ButtonClick(object? sender, EventArgs e)
        {
            // 리스트를 생성합니다.
            List<string> list = new List<string>();

            // 리스트에 체크된 요소를 추가하고자 반복문을 사용합니다.
            foreach (var item in Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if(checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }
            }

            // 리스트를 붙여 문자열을 만듭니다.
            MessageBox.Show(string.Join(",", list));
        }
    }
}
