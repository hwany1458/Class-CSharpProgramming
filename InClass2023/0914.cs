using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 : 쌍따옴표("") vs 문자 : 작은따옴표('')
            Console.WriteLine("고급프로그래밍");
            string str;   // str이라는 변수이름으로 문자열 형태의 변수를 선언
            str = "디지털콘텐츠공학과";
            string str1 = "원광대학교";
            string res;
            // 문자열 덧셈(+)은 문자열을 (단순하게) 연결시켜줌
            res = str1 + str;

            Console.WriteLine(res);

            Console.WriteLine(123+456);  // 정수 + 정수
            Console.WriteLine("123" + "456");  // 문자열 + 문자열 
            Console.WriteLine("123"+456);  // 문자열 + 정수 --> 문자열

            // 불 
            bool a = true;  // a라는 이름으로 불 형태의 변수를 선언
            Console.WriteLine(a);

            int intValue = 10;
            intValue += 20;  // intValue = intValue + 20;
            Console.WriteLine(intValue);

            str1 += "1학년";   // str1 = str1 + "1학년"
            Console.WriteLine(str1);

            int b = 100;
            Console.WriteLine(++b);
            Console.WriteLine(b++);

            Console.WriteLine(b.GetType());

            // 정수형 변수 x를 선언하고 값(1000)을 할당하고 출력하세요
            int x;   // x라는 이름으로 정수형 변수를 선언
            x = 1000;
            Console.WriteLine(x);

            var y = 1000;
            // y라는 이름으로 ?? 변수를 선언하고, 
            // 값을 할당할 때 데이터타입 저징됨
            // var로 변수를 선언할 때는 항상 초기화도 함께 해줘야 함
            var z = "이용환";

            /// 다음 시간에 ...
            double aa = 123.456;
            aa = 123;

            var bb = 123.456;
            bb = 123L;
            
            Console.WriteLine(y);

            /*
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

        }
    }
}
