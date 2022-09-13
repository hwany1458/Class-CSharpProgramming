using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수형 연산 결과는 정수형으로 나옴
            Console.WriteLine(10 / 3);
            Console.WriteLine(10 % 3);

            // 정수형 변수 선언
            int a;  // 선언
            a = 10; // 값 할당
            int b = 20;
            Console.WriteLine(a+b);
            // 정수형 4바이트 (-2^31 ~ 2^31)

            // overflow  -- 긴정수(long)으로 선언
            long  c = 10000000000;
            Console.WriteLine(c);
            long f = 100L;

            // 실수형
            // in C, float or double
            float d = 3.4f;
            Console.WriteLine(d + 1.0f);

            double e = 5.6;
            Console.WriteLine(e / 1.0);

            // 문자형 
            // in C, char
            char g = 'A';
            Console.WriteLine(g);
                            // in C, 
            char aa = 'A';  // ASCII 코드값이라서 정상적으로 동작
            char bb = '가'; // 선언은 1바이트인데, 한글로 2바이트가 들어가서 깨짐

            // in C#, char은 2바이트로 사용됨
            Console.WriteLine(aa);
            Console.WriteLine(bb);

            // 문자 덧셈
            Console.WriteLine(aa + 1);
            Console.WriteLine('A' + 'B');
            // 문자를 아스키코드로 바꾼 다음, 덧셈 연산

            // 문자열형
            string h = "밥먹고 합시다";
            Console.WriteLine(h);

            // 문자열 덧셈
            Console.WriteLine("abc" + "def");
            // 문자열 + 문자열 = 문자열 (2개 문자열을 결합/연결 시킴)
            Console.WriteLine("abc" + 123);
            // 문자열 + 숫자 = 문자열 (숫자를 문자열로 바꾼 다음, 문자열 결합/연결)

            // 각자 살펴보세요
            Console.WriteLine(123 + 456);
            Console.WriteLine("123" + 456);
            Console.WriteLine("123" + "456");

            // 불형
            // in C, 0 이면 참, 0 이 아니면 거짓
            // in C#, bool
            bool i = true;
            Console.WriteLine(i);

            // 논리연산
            Console.WriteLine(10 >= 20);

            // 강의자료 2장 PPT 37페이지 -- 예시로 출력해보세요

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(uint.MinValue);

            // 과제 예 (63페이지, 코드2-2)
            Console.WriteLine(52);
            // in C
            //printf("%d", 52);
        }
    }
}
