using System;

namespace ConsoleApp3
{
    // 클래수 선언 방법
    //class 클래스명 { .. }
    class MyMath
    {
        // 변수선언 (객체의 상태, 속성을 저장하기 위해)

        // 메소드선언 (객체의 행위, 동작을 시키기 위햬)
        // 접근권한자 반환하는데이터타입 메소드명(매개변수들) { .. }
        
        // 합 구하기 메소드(함수)
        public int Sum(int a, int b)
        {
            return (a + b);
        }

        // 제곱 구하기
        public int SQ(int a)
        {
            return (a * a);
        }

        // 절대값 구해서 출력하기
        public void Absol(int a)
        {
            // 양수인지 음수인지 판별
            if (a >= 0)  // 양수일때
            {
                Console.WriteLine("[양수] 절대값=" + a);
            }
            else  // 음수일때
            {
                Console.WriteLine("[음수] 절대값=" + (-a));
            }
        }

        // 곱 구하기
        // 테스트(#1) (public -> private)
        public int Multiply(int a, int b)
        {
            return (a * b);
        }
    }


    // 이름이 Program 인 클래스를 선언
    class Program
    {
        static void Main(string[] args)
        {
            // 클래스에서 객체를 인스턴스화
            //클래스 객체명 = new 클래스();
            MyMath obj = new MyMath();
            
            int res = obj.Sum(10, 20);
            Console.WriteLine(res);
            Console.WriteLine( obj.SQ(5));

            obj.Absol(-100);

            // 10*20 을 계산해서 출력해보세요
            // 테스트(#1)에서 접근권한자를 private로 바꿀 경우, 외부에서 접근이 안되기 때문에 여기에서 오류 발생
            // 다시 public로 바꾸라
            res = obj.Multiply(10, 20);

        }
    }

}
