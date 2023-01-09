using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //-------------------------------------
    // 하이딩, 오버라이딩 실습
    //-------------------------------------
    // 부모클래스
    class Parent {
        // 동일한 이름으로 변수, 메소드()
        public string a = "YongHwan";
        public void Method() { Console.WriteLine("부모클래스 Method()메소드 호출"); }
        public virtual void Test() { Console.WriteLine("부모클래스 Test()"); }

        // 생성자
        public Parent() { Console.WriteLine("부모클래스 생성자 호출"); }
        public Parent(int a) { Console.WriteLine("부모클래스 생성자 with integer parameter"); }
        public Parent(string str) { Console.WriteLine("부모클래스 생성자 with 문자열 parameter"); }
    }

    // 부모클래스(Parent)에서 상속받아 만든 자식클래스
    class Child : Parent {
        // new를 붙여서, 하이딩 시킴 (기본적으로)
        public new int a = 1234;
        public new void Method() { Console.WriteLine("자식클래스 Method() 호출"); }
        public override void Test() { Console.WriteLine("자식클래스 Test()"); }

        // 생성자
        // 호출되는 부모클래스 생성자의 매개변수를 base()에 맞춰서 호출함
        public Child() : base("조규성")
        { Console.WriteLine("자식클래스 생성자 호출됨"); }
    }


    // 상속 제한 실습 (sealed)
    // 만약 상속을 받지 못하게 막고 싶으면 sealed키워드를 붙여줌
    abstract class Animal
    {
        public virtual void Test() { } 
    }
    
    class Bear : Animal
    {
        public override void Test()
        {
            base.Test();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 클래스로부터 객체를 생성
            //클래스 객체명 = new 클래스()
            // 자식클래스로부터 객체를 생성할 경우, 
            // 부모클래스의 생성자와 자식 클래스의 생성자가 같이 실행됨
            // (부모클래스 생성자가 먼저 호출됨)
            Child obj1 = new Child();

            // 부모클래스, 자식클래스에서 각각 변수와 메소드()에 동일한 이름을 사용한 경우
            Child obj2 = new Child();
            // 자식클래스의 변수, 메소드() 호출해봄
            // new키워드를 써서 하이딩시킴 (부모클래스에 있는 동일한 이름의 변수, 메소드()를 숨김
            Console.WriteLine("자식클래스의 변수 " + obj2.a);
            obj2.Method();

            Console.WriteLine("부모클래스의 변수" + ((Parent)obj2).a );
            ((Parent)obj2).Method();

            // override키워드를 써서 오버라이딩시킴 (부모클래스에 있는 동일한 이름의 메소드()를 덮어씀
            // (자식클래스에서) 오버라이딩하려면, 부모클래스에서 virtual키워드를 써줘야 함
            obj2.Test();
            // 부모클래스의 Test() 호출해 봅니다
            ((Parent)obj2).Test();

            //-----------------------
            // abstract키워드를 써서 클래스를 정의하면
            // 해당 클래스에서 객체를 (직접) 생성하지 못하고 (만약 생성하면, 오류발생)
            // 해당클래스로부터 무조건 상속을 받아서 만든 클래스를 이용해야 함
            // Bear클래스처럼 상속받아서만 사용할 수 있음
            //Animal obj3 = new Animal();
            
        }
    }
}
