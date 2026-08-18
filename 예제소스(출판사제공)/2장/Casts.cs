namespace Casts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-57: 자료형 변환
            // 오류가 발생하므로 주석으로 처리했습니다.
            // long 자료형을 int 자료형으로 변환합니다.
            // long longNumber1 = 2147483647L + 2147483647L;
            // int intNumber1 = longNumber1;
            // Console.WriteLine(intNumber1);


            // 코드 2-58: 강제 자료형 변환
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;


            // 코드 2-60: 강제 자료형 변환의 데이터 손실 미발생
            // long 자료형을 int 자료형으로 변환합니다.
            long longNumber2 = 52273;
            int intNumber2 = (int)longNumber2;
            Console.WriteLine(intNumber2);


            // 코드 2-63: 문자열을 숫자로 변환
            // 오류가 발생하므로 주석으로 처리했습니다.
            // string 자료형을 int 자료형으로 변환합니다.
            // string numberString = "52273";
            // int intNumber3 = (int)numberString;
            // Console.WriteLine(intNumber3);


            // 코드 2-65: 숫자로 변환할 수 없는 문자열을 변환하는 경우
            // 예외가 발생하므로 주석으로 처리했습니다.
            // Console.WriteLine(int.Parse("52.273"));
            // Console.WriteLine(int.Parse("abc"));


            // 코드 2-69: 간단한 문자열 변환
            int number = 52273;
            string outputA = number + "";
            Console.WriteLine(outputA);

            char character = 'a';
            // 오류가 발생하므로 주석으로 처리했습니다.
            // string outputB = character + "";
            // Console.WriteLine(outputB);
         }
    }
}
