using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int g = 0;
        // var z = 10;  -- 에러 발생
        // var로 변수를 선언할때는 지역변수만 가능

        static void Main(string[] args)
        {
            // a라는 이름으로 정수형 변수를 선언
            // (대입연산자를 기준으로) 오른쪽의 값을 왼쪽에 대입(넣는다) -- 값을 할당
            int a = 10;
            a += 10;  // a = a + 10;
            Console.WriteLine(a);

            // 각각 몇이 출력될까요?
            Console.WriteLine(++a);
            Console.WriteLine(a++);
            
            Console.WriteLine(a--);
            Console.WriteLine(--a);

            // 데이터타입 검사
            Console.WriteLine(a.GetType());

            // 변수 사용법
            // (1) 변수 선언, (2) 값을 할당
            // (1)에서 데이터타입을 지정 int, double, char, string, bool
            // 예, int a;
            // v라는 이름으로 변수를 선언, 값(10)을 할당할 때, 데이터타입이 지정된
            var v = 10;  // 지역변수

            // int a = 10;
            // int a; a = 10; -- 변수선언과 값할당을 따로 할수 있지만,
            //var x;          -- var에서는 선언과 할당을 동시에 해줘야 함
            //x = 100;
            Console.WriteLine(v.GetType());

            // in C, 
            // printf() -- 콘솔 출력, scanf() -- 콘솔 입력(키보드)
            // in C#,
            // Console.WriteLine(), Console.ReadLine()

            string str = Console.ReadLine();
            Console.WriteLine(str + 1);

            int score;
            score = int.Parse(str);
            Console.WriteLine(score + 1);

        }
    }
}
