namespace LabelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 코드 9-23: 레이블과 링크 레이블 생성
            InitializeComponent();

            // 제대로 출력되지 않을 경우
            // height 변수를 적절하게 조절해서 사용해주세요.
            int height = 23;

            // 레이블과 링크 레이블을 생성합니다.
            Label label = new Label()
            {
                Text = "글자",
                Location = new Point(10, 10),
                Height = height
            };
            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "글자",
                Location = new Point(10, 50),
                Height = height
            };

            // 요소에 이벤트를 연결합니다.
            linkLabel.Click += LabelClick;

            // 요소를 화면에 추가합니다.
            Controls.Add(label);
            Controls.Add(linkLabel);
        }

        private void LabelClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();

            // 코드 9-24: 웹 페이지로의 링크
            // System.Diagnostics.Process.Start("https://hanbit.co.kr");

            // 코드 9-25: 응용 프로그램으로의 링크
            // System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
