namespace DataBindForm
{
    public partial class Form1 : Form
    {
        class Product
        {
            // 코드 10-17: 데이터 그리드 뷰 사용
            public string Name { get; set; }
            public int Price { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            // 코드 10-14: 콤보 박스와 리스트 박스 생성
            /* var dataSource = new string[] { "고구마", "감자", "토마토" };
            comboBox1.DataSource = dataSource;
            listBox1.DataSource = dataSource; */


            // 코드 10-15: 콤보 박스 선택 이벤트
            /* // 콤보 박스 선택 이벤트 연결
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;*/


            // 코드 10-16: 콤보 박스와 리스트 박스 설정
            // 데이터 소스를 선택합니다.
            var dataSourse = new List<Product>
            {
                new Product() { Name = "고구마", Price = 500 },
                new Product() { Name = "감자", Price = 600 },
                new Product() { Name = "사과", Price = 700 }
            };

            // 콤보 박스 설정
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Price";
            comboBox1.DataSource = dataSourse;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            // 리스트 박스 설정
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Price";
            listBox1.DataSource = dataSourse;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

            // 코드 10-17: 데이터 그리드 뷰 사용
            dataGridView1.DataSource = dataSourse;
        }

        // 코드 10-15: 콤보 박스 선택 이벤트
        /* private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedIndex + ": " + comboBox1.SelectedItem;
        }
        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedIndex + ": " + listBox1.SelectedItem;
        } */
        
        // 코드 10-16: 콤보 박스와 이벤트 박스 설정
        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            label1.Text =
                comboBox1.SelectedIndex
                + ": " + comboBox1.SelectedValue
                + ": " + ((Product)comboBox1.SelectedItem).Name;
        }
        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            label1.Text =
                comboBox1.SelectedIndex
                + ": " + comboBox1.SelectedValue
                + ": " + ((Product)comboBox1.SelectedItem).Name;
        }
    }
}
