using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DCMath
    {
        // 속성 + 기능(동작/행위)
        // 속성: 변수로, 기능은 메소드로

        // in C, 동일한 함수이름을 사용할 수 없음
        // in C#, 동일한 메소드이름을 사용할 수 있음 (overloading)
        // [메소드이름+매개변수]로 구분
        public int Absol(int x)   // 정수 절대값
        {
            int res;
            if (x >= 0) res = x;
            else res = -x;
            return res;
        }
        public int Absol(int x, int y)
        {
            return x;
        }
        public int Absol()
        {
            return 0;
        }
        public double Absol(double x)  // 실수 절대값
        {
            double res;
            if (x >= 0.0) res = x;
            else res = -x;
            return res;
        }
        
        public float Absol(float x) // 짧은실수(float) 절대값
        {
            float res;
            if (x >= 0.0) res = x;
            else res = -x;
            return res;
        }
        // 큰정수(long) 절대값

        /*  메소드이름+매개변수 가 동일해서 오류 발생
         *  오류메시지 : 동일한 매개변수 형식을 가진 ... 멤버를 미리 정의 
        public double Absol(float x)
        {
            double res;
            if (x >= 0.0) res = (double)x;
            else res = (double)-x;
            return res;

        }
        */
    }

    class Product
    {
        // 속성
        public string name;
        public int price;

        // 메소드 --- 생성자, 오버로딩
        public Product()
        {
            Console.WriteLine("Constructor is called ...");
        }
        public Product(string str, int prc)
        {
            
            if (prc >= 0) { 
            this.name = str;
            this.price = prc;
            } else
            {
                Console.WriteLine("가격을 잘못 입력했습니다");
            }
        }
        public Product(string str)
        {
            this.name = str;
        }
        
        // 소멸자
        ~Product()
        {
            Console.WriteLine("Destructor is called ......");
        }

        // 캡슐화 (잘못되는 데이터를 들어오지 않도록 방지)
        // 가격이 (-)인 경우는 없으므로, (-)수치가 들어오면 잘못된 것임
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 클래스 객체명 = new 클래스();
            DCMath obj1 = new DCMath();
            Console.WriteLine(obj1.Absol(-10));
            Console.WriteLine(obj1.Absol(-3.4));

            Product obj2 = new Product();
            Product obj3 = new Product("짜장면", 8000);
            Console.WriteLine(obj3.name);
            Console.WriteLine(obj2.name);  // 빈값(or 널?)

            // 과제 (P.284 코드6-17)
            // 22번째 줄 다음에 .. 
            // Product obj4 = new Product(); 
            // (1번) 이거를 추가한 다음에, 만들어진 개수는 몇으로 나올까요?
            // (2번) 만약 2개 생성되었다고 나오면, 
            // 어떻게 수정해야 3개 생성되었다고 나올수 있는지 코드6-17을 수정해보세요

            Product obj4 = new Product("짬뽕", -1000);
            Console.WriteLine("생성된 객체 이름=[" + obj4.name + "]");

            // 프로그램 종료되면서 객체가 제거되어, 소멸자가 호출됨
        }
    }
}
