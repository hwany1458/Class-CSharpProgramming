namespace DialogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object? sender, EventArgs e)
        {
            // 코드 11-14: 대화상자의 ShowDialog() 메서드
            /* saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName); */

            // 코드 11-15: 파일 필터링
            saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);

            // 코드 11-16: 대화상자 동적 생성
            /* SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            MessageBox.Show(dialog.FileName); */
        }

        private void saveFileDialog1_FileOk(object? sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
