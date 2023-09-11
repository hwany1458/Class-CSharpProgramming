using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // in C, printf("\n"); 와 (기능적으로) 동일
            Console.WriteLine("C# 프로그래밍");

            // 정수형
            Console.WriteLine(5 % 3);  // + - * / % 

            // 변수사용 (1)변수선언, (2)값할당
            // 정수형 변수
            // in C, int 변수이름;
            int integerVariable;
            integerVariable = 1001;
            Console.WriteLine(integerVariable);
            Console.WriteLine("최대=" + int.MaxValue + ", 최소=" + int.MinValue);
            
            // overflow (범람)
            // integerVariable = 1234567890123;

            // 긴 정수형 (정수보다 큰 또는 작은 값을 처리)
            long longVariable = 1234567890123;
            Console.WriteLine(longVariable);

            // 실수형(.)
            // 실수에서 f가 붙은 건, float형 실수를 의미
            float floatVariable = 3.4f;
            double doubleVariable = 5.6;
            Console.WriteLine(doubleVariable + 7.8);
            Console.WriteLine(floatVariable - 1.2f);

            // 문자('')
            char charVariable = 'A';
            Console.WriteLine(charVariable);

            // in C, char로 선언하면 1바이트(8비트)로 처리
            // in C#, char를 2바이트로 처리 
            // 한글 1문자가 2바이트이기 때문에, C는 깨지고 C#에서는 안깨짐
            char koreanCharVariable = '가';
            Console.WriteLine(koreanCharVariable);

            // 문자+문자 -- 아스키코드로 변환한 후,덧셈연산
            Console.WriteLine('A' + 'B');
        }
    }
}
