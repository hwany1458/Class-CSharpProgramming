using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 클래스 생성 방법
    //class 클래스명 { }
    // (1번위치)  클래스 밖에 선언 
    // -> (전역변수처럼) 다른 쪽에서 사용 가능
    class Cat
    { 
        // 속성[데이터-변수] + 기능(동작)[메소드-함수동일]
        public string name;
        public void Sleep() { }
    }

    class Program
    {
        // (2번위치) 클래스 안에 선언
        // -> (지역변수처럼) 다른 쪽에서는 사용 불가능
        // (다른말로는) 이쪽 안에서만 사용 가능
        class Dog
        {
            public string name;
            public int age;
            public void Sleep() { }
            public void Run() { }
        }

        static void Main(string[] args)
        {
            // 클래스에서 객체 생성 방법
            //클래스 객체명 = new 클래스();
            Cat obj = new Cat();
            obj.name = "홍혁진";
            obj.Sleep();
            Console.WriteLine(obj.name);

            Dog obj2 = new Dog();
            obj2.name = "멍멍이";
            obj2.age = 3;
            obj2.Run();
            Console.WriteLine(obj2.name + "은 " + obj2.age + "살 입니다");

            ClassCreation obj3 = new ClassCreation();
            obj3.name = "앵무새";
            Console.WriteLine(obj3.name);
        }
    }
}
