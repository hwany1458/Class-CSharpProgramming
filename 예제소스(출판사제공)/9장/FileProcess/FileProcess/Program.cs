namespace FileProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 9-16: 파일에 문자열 쓰기
            File.WriteAllText("c:\\test\\test.txt", "문자열을 파일에 씁니다.");

            // 코드 9-17: @ 기호를 사용한 문자열(Verbatim String: 축자 문자열)
            File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 씁니다.");
            // 코드 9-18: 파일 읽기
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));

            // 코드 9-19: using 구문에서 StreamWriter 클래스의 인스턴스 생성
            // 코드 9-20: StreamWriter 클래스로 파일에 문자열 쓰기
            using (StreamWriter writer = new StreamWriter(@"c:\test\test.txt"))
            {
                writer.WriteLine("안녕하세요.");
                writer.WriteLine("StreamWriter 클래스를 사용해");
                writer.WriteLine("글자를 여러 줄 입력해봅니다.");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }
            }

            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));

            // 코드 9-21: using 구문에서 StreamReader 클래스의 인스턴스 생성
            using (StreamReader reader = new StreamReader(@"c:\test\test.txt"))
            {
                string lineA = reader.ReadLine();
                Console.WriteLine(lineA);

                // 코드 9-22: StreamReader 클래스로 파일 한 줄씩 읽기
                string lineB;
                while ((lineB = reader.ReadLine()) != null)
                { 
                    Console.WriteLine(lineB);
                }
            }
        }
    }
}
