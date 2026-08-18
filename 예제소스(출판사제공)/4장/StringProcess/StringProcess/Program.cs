namespace StringProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 4-26: 대문자화와 소문자화
            string input1 = "Potato Tomato";
            Console.WriteLine(input1.ToUpper());
            Console.WriteLine(input1.ToLower());


            // 코드 4-27: 문자열 자르기
            string input2 = "감자 고구마 토마토";
            string[] inputs = input2.Split(new char[] { ' ' 􀁞);
            
            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }


            // 코드 4-28: 문자열 양옆의 공백 제거
            string input3 = " test         \n";
            Console.WriteLine("::" + input3.Trim() + "::");


            // 코드 4-29: 배열을 문자열로 변환
            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));
        }
    }
}
