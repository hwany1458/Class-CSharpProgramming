using System;

namespace ConsoleApp3
{
    //(1) 클래스 밖에 클래스를 선언
    class Student
    {
        // 변수 선언 
        // 접근권한자 : 
        // public (외부에서 접근할 수 있게 권한을 열어줌)
        // private (외부에서 접근할 수 없게 막아줌)
        public int grade;  // 학년
        public int stNumber; // 학번
        // 아무말안함
        public string gender; // 성별
        public string stName;  // 이름, 키, 몸무게, 시력, 대학소속, 가족관계, 부모 ...
        public float height;  // 키
        public float weight;  // 몸무게
        public float lVision; // 시력
        public float rVision; // 시력
        public float[] vision = { 0.0f, 0.0f }; // 시력
        public string belong;// 대학소속 ....
        public int age; // 나이
        public DateTime bDay;  // 생년월일

    }

    class Product
    {
        public string pName;  // 제품명 (외부에서도 접근할 수 있게 풀어줌)
        public int pPrice;   // 가격
        private string pCompany;  // 제조사 (나만 쓸수있게 = 외부에서 접근하지 못하게)
    }

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
        // 테스트 (public -> private)
        private int Multiply(int a, int b)
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
            res = obj.Multiply(10, 20);

        }
    }


    // 숙제
    // 

}
