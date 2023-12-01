using System;

namespace ConsoleApp3
{
    class Student
    {
        //------ 변수 Variables
        public string name;  // 학생이름
        public int stNumber;  // 학번
        private int height;  // 키
        
        
        private int weight;  // 몸무게
        // weight에 게터, 셋터
        public int GetWeight() { return this.weight; }
        public void SetWeight(int w) { this.weight = w; }

        public int age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public int grade { get; set; }  // 학년

        //------ 함수(메소드) Methods
        // 접근권한자 반환데이터타입 함수명(매개변수) {}
        public bool GoToSchool()
        {
            return true;
        }

        // 생성자 -- 매개변수 있는 놈
        public Student(string n, int sn)
        {
            this.name = n;
            this.stNumber = sn;
        }

        public Student(string n)
        {
            this.name = n;
        }

        // 소멸자
        ~Student()
        {
            // 객체가 소멸(제거)될 때 처리해야할 부분을 이쪽에서 처리
            Console.WriteLine("소멸자: 메모리해제 등 처리해주세요..");
        }

        // 명칭 : setter (세터) -- 값을 넣어주는 놈
        // 함수(메소드) -- 매개변수로 값을 받아서, 객체의 속성값에 할당
        public void SetHeight(int h)
        {
            // 잘못된 데이터가 들어오면 저장하지 않도록 수정
            if (h > 0) { 
                this.height = h;
            } else
            {
                Console.WriteLine("사용자오류] 입력된 데이터가 잘못되었습니다");
            }
        }

        // 명칭 : getter (겟터) -- 값을 받아오는 놈
        // 함수(메소드) -- 매개변수없이 호출하는데, 객체의 속성값을 반환
        public int GetHeight()
        {
            return this.height;
        }

    }

    // 이름이 Program 인 클래스를 선언
    class Program
    {
        static void Main(string[] args)
        {
            // in C
            // (변수선언) int a;  데이터타입 변수명;
            // (함수선언) void funcName() {..}  반환데이터타입 함수명(매개변수) {}
            // in C#
            // 변수선언, 함수선언 -- 동일
            // 접근권한자 : public, private

            // 클래스에서 객체를 인스턴스화할 때, 매개변수 없이 생성자를 호출한 경우
            //Student student = new Student();
            //student.name = "상현";

            // 오류: 보호수준 .... (클래스 선언에서 변수의 접근권한을 private)
            // student.stNumber = 20231234;

            // 인스턴스화할 때, 매개변수를 넘겨주는 생성자를 호출
            Student student = new Student("X상현", 20231234);

            // private 선언(을 바꿔)해서 외부에서 접근하지 못함 (오류남)
            //student.height = -100;
            // 근데 값은 넣고 싶어
            // -- 속성에 직접 접근하지않고 public 함수에 접근해서 값을 넣음
            student.SetHeight(-100);

            // 신입생이라서 아직 학번이 안나옴
            Student newer = new Student("스티브짭스");

            // 학번부여 이후..
            newer.stNumber = 12345679;

            bool res = student.GoToSchool();

            if (res) { Console.WriteLine(student.name + " 출석했습니다"); }
            else { Console.WriteLine(student.name + " 출석하지 않았습니다"); }

            //Console.WriteLine(student.name + " 키는 " + student.height);
            // 오류남 -- height 속성이 private으로 선언되어 있어서
            // 직접 접근을 하지 못함
            // 직접 접근하지 않고 .. 값을 넘겨주는 함수를 호출해서 (대신) 받아옴
            Console.WriteLine(student.name + " 키는 " + student.GetHeight());
        }
    }

}
