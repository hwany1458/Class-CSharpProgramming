using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    //sealed class Weapon  // 무기클래스 (부모클래스로 사용)
    // 상속받지 못하게 막으려면 sealed를 붙여줌
    // (오류메시지) sealed 형식은 파생될 수 없음
    class Weapon  // 무기클래스 (부모클래스로 사용)
    {
        public int attackPoint; // 공격력

        public string namePublic;
        protected string nameProtected;
        private string namePrivate;

        // 겟터, 셋터
        public string GetNamePrivate() { return namePrivate; }
        public void SetNamePrivate(string n) { this.namePrivate = n; }

        public void Attack() // 공격하다()
        { Console.WriteLine("Weapon attack");  }

        // 접근제한자 체크 (변수, 메소드 동일한 방법으로 적용)
        public void MethodPublic() { Console.WriteLine("부모클래스, Public 메소드 호출"); }
        protected void MethodProtected() { Console.WriteLine("부모클래스, Protected 메소드 호출"); }
        private void MethodPrivate() { Console.WriteLine("부모클래스, Private 메소드 호출"); }

        public void CallMethodInternal()
        {
            // 내부에서 메소드 호출
            MethodPublic();
            MethodProtected();
            MethodPrivate();
        }

    }
    class Gun : Weapon   // 무기클래스를 상속받아 만든 총클래스
    {
        public int magazine;  // 탄창;
        public void reload()  // 재장전하다()
        { Console.WriteLine("Gun reload"); }

        // Weapon으로부터 상속받아서 만들어진 Gun(총)클래스

        public void CallMethodChild()
        {
            // (상속된) 자식클래스에서 메소드 호출
            // 상속받은 클래스에서 .. 부모클래스에서 Private으로 선언된 변수, 메소는 접근 불가
            MethodPublic();
            MethodProtected();
            //MethodPrivate();
            // (오류메시지) 보호수준 때문에 접근할 수 없음
        }

        public void SetDataChild()
        {
            // (상속된) 자식클래스에서 변수 접근
            // 상속받은 클래스에서 부모클래스의 private 선언 변수에서는 접근 불가
            base.namePublic = "YongHwan";
            base.nameProtected = "HyunSoon";
            //base.namePrivate = "HyunSeo";
        }
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

            // 내부클래스 호출해보려고
            Weapon obj = new Weapon();
            obj.CallMethodInternal();

            // 외부클래스에서 호출
            // 외부클래스에서는 public으로 선언된 변수, 메소드만 접근이 가능
            // (=) protected, private으로 선언된 변수, 메소드는 접근 불가
            obj.MethodPublic();
            //obj.MethodProtected();
            //obj.MethodPrivate();
            // (오류메시지) 보호수준 때문에 접근할 수 없음

            // 외부클래스에서 변수 접근
            obj.namePublic = "YongHwan Lee";
            //obj.nameProtected = "HyonSoon Lee";
            //obj.namePrivate = "HyunSeo Lee";
            // 외부클래스에서는 protected, private 선언된 변수에서는 접근 불가

            //------------------------
            // private으로 선언된 변수에 접근하는 코드
            // private으로 선언된 변수에는 직접 접근을 하지 못하므로,
            // public으로 만들어진 겟터, 셋터를 호출
            Weapon obj2 = new Weapon();
            //obj2.namePrivate = "외부접근";  (접근이 불가)
            obj2.SetNamePrivate("외부접근");
            Console.WriteLine("외부클래스에서 접근가능한지를 확인하기 위해 ---" + obj2.GetNamePrivate());

        }

    }

    // 숙제
    // 슬라이드 24쪽 코드 작성해 오기
}
