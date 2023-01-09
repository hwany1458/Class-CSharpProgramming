using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Weapon  // 무기클래스
    {
        public int attackPoint; // 공격력
        public void Attack() // 공격하다()
        { Console.WriteLine("Weapon attack");  }
    }
    class Gun : Weapon   // 무기클래스를 상속받아 만든 총클래스
    {
        public int magazine;  // 탄창;
        public void reload()  // 재장전하다()
        { Console.WriteLine("Gun reload"); }
    }

    class Knife : Weapon { }  // 무기클래스를 상속받아 만든 칼클래스

    class Bow :Weapon  // 무기클래스를 상속받아 만든 활클래스
    {
        public int range;  // 사정거리
    }


    class Program
    {
        static void Main(string[] args)
        {
            // 클래스에서 객체 생성하는 방법
            //클래스 객체명 = new 클래스();
            Bow bow = new Bow();
            bow.range = 10;
            bow.attackPoint = 10;
            bow.Attack();
            Console.WriteLine("공격력은" + bow.attackPoint);

            Knife knife = new Knife();
            knife.attackPoint = 15;
            Console.WriteLine("칼 공격력은" + knife.attackPoint);
            knife.Attack();

            // 수행
            // (1) 총 객체를 만들고, 변수에 값을 넣고 메소드()를 호출해 봅니다
            // (2) 무기클래스를 상속받아, 창클래스를 선언
            // (3) 무기클래스를 상속받아, 수류탄클래스를 선언
        }
    }

    // 숙제
    // Enemy클래스 생성 -- hp, name, hit(), shout()
    // Monster클래스 생성 -- Enemy에서 상속받아
    // Zombie클래스 생성 -- Enemy에서 상속받아
    // 몬스터는 뭐하는 놈, 좀비는 뭐하는 놈인지를 적어오세요
}
