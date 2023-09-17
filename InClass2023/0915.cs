using System;

namespace FirstProject
{
    class Program
    {
        int aa = 0;  // 전역변수
        // var cc = 1001; -- 컴파일 오류발생 (var은 지역변수로만 사용가능)

        static void Main(string[] args)
        {
            // var 사용 제약 
            // (1) 선언과 동시에 값을 할당해야 함
            // (2) 지역변수만 가능 (전역변수로 선언은 못함)

            // int, double, char, string, bool .. 가능
            int a;   // 변수선언  (지역변수 -- 함수 내부에서 선언)
            a = 100; // 값할당
            int b = 200;  // 변수선언 + 값할당

            var c = 300;  // 지역변수(사용가능)
            //var d;  -- 초기화가 안되서 컴파일 오류 발생
            //d = 400;

            Console.WriteLine(c);  // in C, printf() 기능
            // in C, 키보드로부터 입력 -- scanf()
            // int inValue; scanf("%d", &inValue);
            // in C#, ReadLine()
            Console.Write("키보드로부터 입력하세요> ");
            string inStr = Console.ReadLine();
            Console.WriteLine(inStr);
            // inStr+1 테스트 --- 키보드로부터 숫자를 입력해도, 문자열로 받아들임 

            // int inVal = Console.ReadLine();
            // 컴파일 오류 -- ReadLine() 함수는 반환데이터타입이 문자열임

            // ReadLine()으로 숫자를 입력받으려면,
            // 입력받은 문자열을 숫자로 형변환  -- int.Parse()

            int inNum = int.Parse(inStr);
            Console.WriteLine(inNum + 1);

            // 정수+정수 = 정수
            // 문자+문자 = 숫자(아스키코드로 변환한 다음, 덧셈 연산)
            // 문자열+문자열 = (연결된) 문자열 
            Console.WriteLine(1+2);
            Console.WriteLine('1'+'2');
            Console.WriteLine("1"+"2");

            // 정수를 문자열로 변환하려면 ToString()함수 사용
            Console.WriteLine(123.ToString());
        }
    }
}
