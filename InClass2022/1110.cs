using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    // 강아지 클래스
    class Dog
    {
        //속성
        public string kind;  // 품종
        public int age;     //나이
        public string name; // 이름
        public string color;    // 강아지 색깔

        // 생성자
        public Dog() { this.age = 0; }
        public Dog(string n) { this.name = n; }

        //기능
        //public void Eat() { Console.WriteLine("먹고"); }
        public void Eat(string str) { Console.WriteLine(str + "를 먹고"); }
        public void Sleep() { Console.WriteLine("자고"); }
        public void Shit() { Console.WriteLine("싸고"); }
        public void Walk() { Console.WriteLine("산책하고"); }
    }

    // 고양이 클래스
    class Cat
    {
        //속성
        public string kind;  // 품종
        public int age;     //나이
        public string name; // 이름

        // 생성자
        public Cat() { this.age = 0; }
        public Cat(string n) { this.name = n; }

        //기능
        //public void Eat() { Console.WriteLine("먹고"); }
        public void Eat(string str) { Console.WriteLine(str + "를 먹고"); }
        public void Sleep() { Console.WriteLine("자고"); }
        public void Shit() { Console.WriteLine("싸고"); }
        public void CatTower() { Console.WriteLine("캣타워 올라가고"); }
    }
    
    // Dog, Cat클래스는 상속과 무관하게 클래스를 선언하여 사용함
    // 재사용성이 낮고, 유지보수가 어려운 단점이 있음
    //-------------------------------------------------------------
    
    // 고양이, 강아지 ... 클래스들이 포함하는 공통적인 부분만을 뽑아냄
    class Animal
    {
        //속성
        public string kind;  // 품종
        public int age;     //나이
        public string name; // 이름

        //기능
        public void Eat(string str) { Console.WriteLine(str + "를 먹고"); }
        public void Sleep(int i) { Console.WriteLine(i + "시에 자고"); }
        public void Shit() { Console.WriteLine("싸고"); }
    }

    // 강아지 클래스 (애니멀 클래스에서 상속 받아서)
    class DogI : Animal
    {
        public string color;    // 강아지 색깔
        public void Walk() { Console.WriteLine("산책하고"); }

    }

    class CatI : Animal
    {
        public void CatTower() { Console.WriteLine("캣타워 올라가고"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // "한별" 고양이 객체 생성, 먹고 자고 올라가고
            Cat cat1 = new Cat("한별");
            Console.WriteLine(cat1.name);
            cat1.kind = "mixed";
            cat1.age = 3;
            //cat1.Eat();
            cat1.Eat("고양이사료");
            cat1.Shit();
            cat1.CatTower();

            // "코코" 강아지 객체 생성, 먹고 싸고 산책하고
            Dog dog1 = new Dog("코코");
            //dog1.Eat();
            dog1.Eat("햄");
            dog1.Shit();
            dog1.Walk();
            
            // "코리" 강아지 객체 생성, 먹고 자고 싸고
            // "몽이" 강아지 객체 생성, 먹고 자고 싸고 산책하고
            // "콩이" 고양이 객체 생성, 먹고 자고
            
            // 코리, 몽이, 콩이 부분은 각자 꼭 작성해 보기 바랍니다.

            // -----------------------------
            // 1차적으로 클래스를 정의했었는데 .. 변경 요구사항이 발생
            // 강아지, 고양이, 뱀, 사자, 앵무새, 사람, 햄스터 ... 클래스 많으면 ... 
            // 전부 찾아가서 바꿔줌 (예를들어, 여기서는 고양이, 강아지 ..)

            // 전부를 일일히 수정해줘야 하는데.. 깜빡하고 못하면 ?? 
            // 클래스들을 독립적으로만 사용하기 때문에 오류가 발생함
            // 이러한 (유지보수에서의 변경 등) 문제가 생겼을 경우, 
            // 재사용성이 낮기 때문에 수정 보완할 항목들이 많아짐
            
            // 효율적인 코딩이 되기 위해서는 코드의 재사용성을 높힐 필요가 있음
            // 클래스 상속 등을 통해, 객체지향의 장점을 극대화 하려고 함

            // ------------------------------------------
            // 상속받은 클래스 사용
            CatI catInh1 = new CatI();
            catInh1.name = "한별";
            // 먹고 자고 올라가고 .... 실행
            // 먹고 자고 --- 상속받은 기능
            catInh1.Eat("건식사료");
            catInh1.Sleep();
            
            // 올라가고는 자식클래스에 독자적으로 선언되어 실행할 수 있음
            catInh1.CatTower();

        }
    }

    // 숙제
    // Enemy클래스 생성 -- hp, name, hit(), shout()
    // Monster클래스 생성 -- Enemy에서 상속받아
    // Zombie클래스 생성 -- Enemy에서 상속받아
    // 몬스터는 뭐하는 놈, 좀비는 뭐하는 놈인지를 적어오세요
}
