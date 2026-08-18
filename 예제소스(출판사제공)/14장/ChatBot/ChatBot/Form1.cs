using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;

            button1.Click += Button1_Click;
        }

        // 인공지능 메시지를 나타내는 클래스
        class Message
        {
            public string role { get; set; }
            public string content { get; set; }

            public Message(string role, string content)
            {
                this.role = role;
                this.content = content;
            }
        }

        // 메시지를 저장하는 리스트
        List<Message> messages = new List<Message>();
        private async void Button1_Click(object? sender, EventArgs e)
        {
            // 사용자 메시지를 읽고
            // UI를 사용하지 못하게 막습니다.
            string userMessage = textBox1.Text.Trim();
            richTextBox1.AppendText("[user] " + userMessage + "\n");
            textBox1.Text = "통신 중....";
            textBox1.Enabled = false;
            button1.Enabled = false;

            // 통신합니다.
            string assistantResponse = await GetOpenAIResponseAsync(userMessage);
            richTextBox1.AppendText("[assistant] " + assistantResponse + "\n");

            // 통신 완료 후 데이터를 출력하고
            // UI를 사용 가능한 상태로 되돌립니다.
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private async Task<string> GetOpenAIResponseAsync(string message)
        {
            // 메시지를 추가합니다.
            messages.Add(new Message("user", message));

            // API 키를 입력합니다.
            string apiKey = "...여기에 API 키를 입력합니다...";

            // HTTP 요청합니다.
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);
            HttpResponseMessage response = await client.PostAsync(
                // Completion API를 사용합니다.
                "https://api.openai.com/v1/chat/completions",
                new StringContent(JsonSerializer.Serialize(new
                    {
                        model = "gpt-3.5-turbo", // 사용료가 가장 저렴한 모델입니다.
                        messages = messages.ToArray()
                    }), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();

            // HTTP 응답을 받고 content를 추출합니다.
            string responseBody = await response.Content.ReadAsStringAsync();
            using JsonDocument document = JsonDocument.Parse(responseBody);

            string assistantMessage = document.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString()!;
            messages.Add(new Message("assistant", assistantMessage));
            return assistantMessage.Trim();
        }
    }
}
