using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    // 클래스이름 부여할 때, 중복되지 않도록 주의할 것
    class DCMath {
        // 클래스 변수 -- 객체를 만들지 않고도 사용할수 있는 변수
        public static double chocoPi = 3.14159;
    }

    class Student
    {
        // 인스턴스 변수 -- 객체가 만들어진 다음, 사용할수 있는 변수
        // 접근제한자 : public, private
        // public 은 공용으로 사용 가능
        // private 은 (외부에서 사용하지 못하고) 자기안에서만 사용 가능
        public string stdName;
        public int stuNum;
        public string phone;
        //public string phone = "010";
        // 객체만들어지면서 (자동으로) 초기화값을 갖도록
        private string socialNo;
    }
    // 

    class Program
    {
        static void Main(string[] args)
        {
            // Math클래스를 사용하여 -10의 절대값을 출력하세요.
            int res = Math.Abs(-10);
            Console.WriteLine(res);

            // 클래스에서 객체 생성 방법
            // 클래스명 객체명 = new 클래스();

            // 다한학생
            Student obj1 = new Student();
            obj1.stdName = "다한";
            Student obj2 = new Student();
            obj2.stdName = "성연";
            // 성연학생 학번, 주민번호를 입력하고 출력하세요
            obj2.stuNum = 20220002;
            //obj2.socialNo = "123456-7891230";
            // 컴파일 오류 발생 
            // private으로 선언된 변수에는 (외부에서) 접근이 불가능
            // 오류메시지: 보호수준때문에 .. 액세스 할수없음

            Console.WriteLine($"{obj1.stdName} -- {obj2.stdName}");
            Console.WriteLine($"{obj2.stdName} {obj2.stuNum}");

            // 변수 생성할 때 초기화 
            int a = 10;
            // 성연학생 이름, 핸드폰번호를 출력하세요
            Console.WriteLine($"{obj2.stdName} {obj2.phone}");
            Console.WriteLine($"{obj1.stdName} {obj1.phone}");

            // 클래스에서 객체를 만들면서 (값을 넘겨줘서) 초기값을 갖도록 객체 생성
            Student obj3 = new Student() { stdName="지원", stuNum=20220003 };
            Console.WriteLine($"{obj3.stdName},{obj3.stuNum},{obj3.phone},");

            // 클래스 변수 사용 예
            // 클래스변수는 new 해서 객체를 생성한 다음에, 변수 사용이 가능한게 아니고
            // new 없이 바로 변수 사용 가능
            // (Math클래스 쓰는 방법과 동일하게)
            Console.WriteLine(DCMath.chocoPi);
        }
    }
}
