using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.(짝수인지 홀수인지를) 구별하려는 변수를 선언
            2.변수에 값 할당 <- 키보드에서 숫자를 입력 받으세요
            3.짝수 / 홀수 구분
            4.만약 짝수이면, “짝수입니다” 출력
            5.만약 짝수가 아니면(홀수면) “홀수입니다”라고 출력
            6.끝
            */

            // 1
            int inputNum;     // 키보드로부터 입력 받는 정수를 저장하기 위해
            string inputStr;  // ReadLine()으로부터 입력 받는 문자열을 저장하기 위해

            // 2
            // ReadLine()의 리턴(반환) 데이터는 문자열 형태
            inputStr = Console.ReadLine();
            inputNum = int.Parse(inputStr);

            // 3, 4 
            if ((inputNum % 2) == 0)  //3
            {
                // 4
                Console.WriteLine("입력받은 " + inputNum + "은 짝수입니다");
                //Console.WriteLine($"입력받은 {inputNum}은 짝수입니다");

                if (inputNum == 0) // 입력 받은 수가 0 이면
                {
                    Console.WriteLine("입력받은 수는 0 입니다");
                }
                else  // 입력 받은 수가 0 이 아니면
                {
                    Console.WriteLine("입력받은 수는 0 이 아닙니다");
                }
            }
            else
            {
                // 5
                Console.WriteLine("입력받은 " + inputNum + "은 홀수입니다");
            }
            // 6. 끝

            // 현재 날짜, 시간을 받음  (컴퓨터 시간)
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Month);

            if (DateTime.Now.Hour < 12)  // 참일때
            {
                Console.WriteLine("오전입니다");
            }
            else // 거짓일때
            {
                Console.WriteLine("오후입니다");
            }

            // 월 : 봄 여름 가을 겨울
            int m = DateTime.Now.Month;
            if ((3 <= m) && (m <= 5))  // 3~5 사이
            {
                Console.WriteLine("봄입니다"); 
            }
            else if ((6 <= m) && (m <= 8))  // 6~8 사이
            {
                Console.WriteLine("여름입니다");
            }
            else if ((9 <= m) && (m <= 11))  // 9~11 사이
            {
                Console.WriteLine("가을입니다");
            }
            else  // 이외, 1,2, 12
            {
                Console.WriteLine("겨울입니다");
            }

        }
    }
}
