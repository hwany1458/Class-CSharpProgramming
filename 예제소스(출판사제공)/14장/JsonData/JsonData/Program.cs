using System.Text.Json;

namespace JsonData
{
    internal class Program
    {
        class Book
        {
            public string name { get; set; }
            public int price { get; set; }
        }

        static void Main(string[] args)
        {
            // 코드 14-1: 익명 객체를 JSON 문자열로 변환하기
            /* var output = JsonSerializer.Serialize(
                new
                {
                    name = "C# Programming",
                    price = 20000
                }
            );

            Console.WriteLine(output); */


            // 코드 14-2: 클래스 객체를 JSON 문자열로 변환하기
            /* var output = JsonSerializer.Serialize(new Book()
            {
                name = "C# Programming", price = 20000
            });

            Console.WriteLine(output); */

            // 코드 14-3: 객체 배열을 JSON 문자열로 변환하기
            var output = JsonSerializer.Serialize(new[] {
                new Book() { name = "C# Programming", price = 20000 },
                new Book() { name = "Unity Programming", price = 20000 },
            });

            Console.WriteLine(output);

            // 코드 14-4: JSON 문자열을 C# 객체로 변환하기
            var parsed = JsonDocument.Parse(output);
            Console.WriteLine(parsed.RootElement[0].GetProperty("name").GetString());
        }
    }
}
