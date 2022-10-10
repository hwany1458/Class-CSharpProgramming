using System;

namespace ConsoleApp1
{
    /*
     * 학생
     * 속성: 학번, 이름, 생년월일, 성별, 핸드폰번호, 주소
     * 기능: 입학하기, 수강신청하기, 출석하기, 시험보기, 졸업하기
     * 
     * 클래스이름: Student
     * */
    class Student
    {
        public int stuNumber;      // 학번
        public string stuName;     // 이름
        public DateTime stuBirth;  // 생년월일
        public int stuGender;      //성별
        string stuCellular;         //핸드폰번호
        public string stuAddress;  // 주소
        // 기본값은 private

        public void Entrance() { }      // 입학하기
        public void CourseRegistration() { }    // 수강신청하기
        public bool Attend() { return true; }   // 출석하기
        public void Examination() { }           // 시험보기
        public void Graduation() { }            // 졸업하기
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 클래스에서 객체 생성 (PPT 14슬라이드 참조)
            // 클래스 객체명 = new 생성자();

            // 학생클래스(Student)로부터 태민학생 객체 생성
            Student taeMin = new Student();
            taeMin.stuName = "태민";  
            taeMin.Entrance();
            bool att = taeMin.Attend();
            if (att) 
            {
                Console.WriteLine($"{taeMin.stuName} 학생이 등교했습니다");
            }
            taeMin.Examination();

            // 학생클래스(Student)로부터 성연학생 객체 생성
            Student sungYeon = new Student();
        }
    }
}
