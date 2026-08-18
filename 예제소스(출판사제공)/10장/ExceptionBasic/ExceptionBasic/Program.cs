namespace ExceptionBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 10-1: 예외 상황 확인
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력하세요:");
            int input = int.Parse(Console.ReadLine());
            // Console.WriteLine("입력한 위치의 값은 '"+ array[input] + "'입니다.");

            // 코드 10-2: 기본 예외 처리
            if (input < array.Length)
            {
                Console.WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");
            }
            else
            {
                Console.WriteLine("인덱스 범위를 넘었습니다.");
            }
        }
    }
}
