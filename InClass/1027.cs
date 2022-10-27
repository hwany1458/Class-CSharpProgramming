using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DCMath
    {
        // 변수선언 영역 ---- 속성 저장
        public double chocoPi = 3.14159;    // 인스턴스변수
        public static double staticPi = 3.14159;  // 클래스변수

        // 메소드선언 영역 --- 기능(동작) 구현
        // 접근제한자 반환데이타타입 메소드명(매개변수들) { }
        // (1) 덧셈처리 메소드
        public int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        // (2) 제곱계산 메소드
        public int Power(int x)
        {
            int res = x * x;
            return res;
        }
        public int Multiply(int x, int y)
        {
            int res = x * y;
            return res;
        }

        // 교재형태에서 수정 : 출력문자열을 매개변수로 받음
        public void Print(string str)
        {
            Console.WriteLine(str);
            // 반환데이터타입이 없어서,
            // void로, return문을 작성하지 않음
        }

        // (입력 정수)+1을 반환하는 Incre() 메소드를 선언 (클래스메소드로)
        public static int Incre(int a)
        {
            int res = ++a;
            return res;
            // 한줄로 쓰면, return a++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 클래스에서 객체 생성 방법
            // 클래스 객체명 = new 클래스();
            DCMath obj = new DCMath();
            Console.WriteLine(obj.Add(100, 200));
            // 1~10사이의 임의의 정수를 1개 뽑아서, 제곱을 구하시오.
            // 단 DCMath 클래스를 사용하여

            Random ran = new Random();
            int temp = ran.Next(1, 11);
            Console.WriteLine("임의의 수는 "+ temp + ", 제곱은 " + obj.Power(temp));  // obj.Multiply(temp, temp)

            // [임의의 수, 제곱] 형태로 Print()메소드를 사용하여 출력하세요
            obj.Print("[" + temp + ", " + obj.Power(temp) + "]");

            // 클래스메소드 예시
            Console.WriteLine(DCMath.Incre(10));
        }
    }
}
