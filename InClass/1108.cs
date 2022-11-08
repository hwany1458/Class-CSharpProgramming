using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // 교재 Box -- 각자 보도록 하시고 여기서는 원(Circle)
    class Circle
    {
        // 속성 + 기능(동작)
        // 속성 : 변수선언, 상태값을 저장
        // 기능(동작) : 메소드, 객체를 동작시키는 
        //public double r; // 반지름 : 속성
        // public에서 private으로 바꾸면 .. 
        // 외부클래스에서 반지름 속성(r)에 접근할 수 없음 -- (A위치)에서 접근 불가

        /*
        private double r; // 반지름 : 속성
        // 겟터, 셋터를 속성으로 (1방법)
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        */
        // 겟터, 셋터를 속성으로 (2방법)
        // 접근권한자를 public, {}안에 get; set;만 기술
        public double r { get; set; }

        public double PI = 3.14159;

        // 생성자
        public Circle()
        {
            Console.WriteLine("생성자 호출됨...");
        }
        public Circle(double r)
        {
            Console.WriteLine("생성자 호출 : 매개변수받음");
            if (r >= 0) { this.r = r; }
            else { Console.WriteLine("오류] 반지름이 0 미만입니다. 잘못 입력했습니다");  }
        }
        // 원면적 구하기
        public double Area()
        {
            double res = PI * this.r * this.r;
            return res;
        }
        // 원둘레 구하기
        public double Circum()
        {
            double res = 2 * PI * this.r;
            return res;
        }

        // 반지름 r 속성의 게터(getter)와 셋터(setter)  -- 교재 P.296 (코드6-28 방법) 메소드
        // getter
        public double GetR() { return r; }
        // setter
        public void SetR(double r)
        {
            // 캡슐화
            if (r >= 0) { this.r = r; }
            else { Console.WriteLine("반지름이 0 미만임..."); }
        }

        // 겟터, 셋터 -- 속성으로 만드는 방법 (2가지)
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Circle클래스에서 객체(obj)를 생성하고 반지름 3.0인 원
            // 면적과 둘레를 출력

            // 객체 생성 방법
            // 클래스 객체명 = new 클래스();
            //Circle obj = new Circle(-3.0);
            // (A위치)
            //Console.WriteLine("반지름=" + obj.r);

            Circle obj = new Circle();
            obj.SetR(3.4);
            double ret = obj.GetR();
            Console.WriteLine("반지름=" + ret);

            Console.WriteLine("면적=" + obj.Area());
            Console.WriteLine("둘레=" + obj.Circum());

            // 속성 1방법으로
            /*
            obj.R = 5.6;  // 셋터 (속성 식이 등호(=)를 기준으로 좌측에 위치 - 오른쪽 값이 왼쪽으로 대입)
            double tmp = obj.R;  // 겟터 (속성 식이 등호를 기준으로 우측에 위치)
            Console.WriteLine("속성으로 읽어온 반지름=" + tmp);
            */
            // 속성 2방법으로
            Console.WriteLine("속성 2방법으로 읽어온 반지름=" + obj.r);
        }
    }

    // 6장.연습문제 
    // 1~5번 교재에 직접 풀기
    // 6~8번 작성해서 결과 확인하기
}
