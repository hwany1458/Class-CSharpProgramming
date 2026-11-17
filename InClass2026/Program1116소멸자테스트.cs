namespace CsharpClassObjectProject
{
    public class TestObject
    {
        private string name;

        // 생성자
        public TestObject(string name)
        {
            this.name = name;
            Console.WriteLine($"{name} 객체가 생성되었습니다.");
        }

        // 소멸자
        ~TestObject()
        {
            Console.WriteLine($"{name} 객체의 소멸자가 실행되었습니다.");
        }
    }

    internal class Program
    {

        static void CreateObject()
        {
            TestObject obj = new TestObject("테스트객체");
            Console.WriteLine("CreateObject() method is done");
        }

        static void Main(string[] args)
        {
            // 객체 생성
            CreateObject();

            Console.WriteLine("\n가비지 컬렉션 실행");
            // 교육용으로 GC 실행을 강제로 요청
            GC.Collect();

            // 소멸자의 실행이 끝날 때까지 기다림
            GC.WaitForPendingFinalizers();

            Console.WriteLine("프로그램 종료");
        }
    }
}
