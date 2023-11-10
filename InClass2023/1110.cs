using System;

namespace ConsoleApp3
{
    // 클래스생성 -- 위치(3가지)
    // 클래스이름은 대문자로 시작하는게 좋습니다 
    //(1) 클래스 밖에 클래스를 선언
    class LG  // LG라는 이름으로 클래스를 선언
    {
        // 데이터(속성) -- 변수 선언

        // 행위(동작) -- 메소드(함수) 선언

    }

    class DooSan
    {
        // 데이터(속성, 상태) -- 변수 선언
        // 접근권한자 데이터타입 변수명;
        public int rank;  // rank라는 이름으로 정수형 변수를 선언
        public int foundedYear;
        public string slogon;

        // 행위(동작, 행위) -- 메소드(함수) 선언
        // 접근권한자 반환데이터타입 메소드명(매개변수, 매개변수..) { // 동작 }
        public void PrintName()
        {
            Console.WriteLine("이름출력하래..");
        }

        // 다형성
        public void PrintName(string str)
        {
            Console.WriteLine("감독이름은 " + str);
        }
    }

    // 클래스 이름을 부여할 때 기존에 제공되는 클래스이름을 피하세요
    class MyMath
    {

    }

    // 이름이 Program 인 클래스를 선언
    class Program
    {
        //(2) 클래스 안에 클래스를 선언
        class KT
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 클래스에서 객체를 인스턴스화 
            // 클래스 객체명 = new 클래스();
            LG obj1 = new LG();
            KT obj2 = new KT();
            SSG obj3 = new SSG();

            Console.WriteLine(Math.Max(10, 20));

            DooSan dooSanBears = new DooSan();
            dooSanBears.rank = 5;
            dooSanBears.foundedYear = 1999;
            dooSanBears.slogon = "최강두산";

            Console.WriteLine(dooSanBears.slogon);
            dooSanBears.PrintName();
            dooSanBears.PrintName("이승엽");

            DooSan obBears = new DooSan();
            obBears.foundedYear = 1982;
            obBears.rank = 1;
        }
    }


    // 숙제
    // 학생(Student) 클래스를 생성
    // 학생객체가 가져야할 속성, 행위(동작)를 정의해서 선언 (클래스안에)
    // 학생클래스에서 3개 이상 객체를 인스턴스화
    // 만들어진 객체에 속성도 넣고 출력, 동작도 시켜보고 ...

}
