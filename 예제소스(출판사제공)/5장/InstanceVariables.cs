namespace InstanceVariables
{
    // 코드 5-11: 인스턴스 변수 선언
    class User
    {
        public string name;
        public string password;
        public string address;
        public string phoneNumber;
        public DateTime regDate;
    }


    // 코드 5-14: 인스턴스 변수를 생성할 때 초기화
    class Product
    {
        public string name = "default";
        public int price = 1000;
    }


    // 코드 5-17: 학생 추상화
    class Student
    {
        public string id;
        public string name;
        public int grade;
        public string major;
        public DateTime birthday;

        /* 계속해서 생각해보세요. */
    }


    // 코드 5-15: 인스턴스 변수를 생성과 동시에 초기화
    internal class Program
    {
        class Product
        { 
            public string name;
            public int price;
        }

        static void Main(string[] args)
        {
            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { name = "고구마", price = 3000 };
        }
    }
}
