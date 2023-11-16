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
    
    // 이름이 Program 인 클래스를 선언
    class Program
    {
        static void Main(string[] args)
        {
            // 변수 쓸려면, 변수선언, 값할당
            // A 타입
            int a;
            a = 100;
            // B 타입 (변수선언하면 초기값 할당)
            int b = 100;


            Console.WriteLine("Hello World!");
            // 클래스에서 객체를 인스턴스화 
            // 클래스 객체명 = new 클래스();
            
            // A
            Product obj1 = new Product(); // 객체생성
            obj1.pName = "갤럭시";
            obj1.pPrice = 1000000;

            // B (객체생성, 초기값 할당)
            Product obj2 = new Product() { pName = "아이폰", pPrice = 1000000 };
            // 생성자를 만들어서 쓸수있음 .. 메소드 학습이후에 다시 애기


            // 방법적인 부분만 언급
            Product obj3 = new Product();
            

            Console.WriteLine(obj1.pName + "의 가격은 " + obj1.pPrice);
            Console.WriteLine(obj2.pName + "의 가격은 " + obj2.pPrice);
            Console.WriteLine(obj3.pName + "의 가격은 " + obj3.pPrice);

            /* 아래 숙제 부분
            Student objSH = new Student();
            Student objGH = new Student();
            Student objJW = new Student();

            objSH.stName = "유상현";
            objSH.grade = 1;
            objSH.lVision = 1.5f;
            // ...

            objGH.stName = "호건희";
            // ..
            
            objJW.grade = 1;
            // ..

            Console.WriteLine(objSH.stName + " 시력=" + objSH.lVision); ;
            */
        }
    }


    // 숙제
    // 학생(Student) 클래스를 생성
    // 학생객체가 가져야할 속성, 행위(동작)를 정의해서 선언 (클래스안에)
    // 학생클래스에서 3개 이상 객체를 인스턴스화
    // 만들어진 객체에 속성도 넣고 출력, 동작도 시켜보고 ...

}
