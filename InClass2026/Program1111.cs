namespace SecondProject
{
    // 접근권한자 class 클래스명 {}
    // 위치(1) -- 클래스 밖에 선언
    public class FirstClass
    {
        // 인스턴스 변수 
        // 클래스 변수 (static)
        public string firstClassName = "Lee YongHwan";
        public string name;
        public int age;

        // 생성자
        public FirstClass()
        {
            this.name = "Test";
            this.age = 1;
            Console.WriteLine("객체가 생성되었습니다");
        }

        public FirstClass(string n, int a)
        {
            this.name = n;
            this.age = a;
        }

        // 오버로딩
        public int Absol(int x)
        {
            if (x >= 0) { return x; }
            else { return -x; }
        }

        public double Absol(double x)
        {
            if (x >= 0) { return x; }
            else { return -x; }
        }

        public float Absol(float x)
        {
            if (x >= 0) { return x; }
            else { return -x; }
        }


        public int Absol(int x, int y)
        {
            if (x >= 0) { return (x+y); }
            else { return -(x+y); }
        }

        public int Absol()
        {
            int x = 0;
            if (x >= 0) { return x; }
            else { return -x; }
        }

    }

    // 이름충돌 안나게, Naming Rule을 지키자!!
    public class HTMath
    {

    }


    public class FishShapedPastry
    {
        // 변수
        // public 접근허용, private 허용불가
        public int amount;
        public double weight;
        public string name;
        private bool err;

        // 함수(메소드)
        // 11.09
        // 교재 Power()
        // 접근권한자 반환되는데이타타입 메소드명(매개변수) {}
        public int Power(int x)
        {
            int res = x * x;
            return res;
        }

        private int PowerPrivate(int x)
        {
            int res = x * x;
            return res;
        }

    }

    internal class Program
    {
        // 위치(2)
        public class SecondClass
        {

        }

        static void Main(string[] args)
        {
            // 클래스타입 객체명 = new 생성자();
            //Car car = new Car();

            /*
            // --- 인스턴스 변수
            // 클래스 new --> 객체생성, 객체변수에 접근
            FirstClass first = new FirstClass();
            Console.WriteLine(first.firstClassName);
            // ---- 인스턴스 메소드
            Console.WriteLine(first.Absol(-10));
            */

            /*
            //--- 클래스 변수 
            // new 하지 않고 (바로) 객체변수에 접근
            Console.WriteLine(FirstClass.firstClassName);
            //--- 클래스 메소드
            Console.WriteLine(FirstClass.Absol(-100));
            */

            //--- 오버로딩
            FirstClass first = new FirstClass();
            Console.WriteLine(first.Absol(10.123f));

            // 생성자에서 초기값을 넣은게 잘 들어갔는지 확인
            Console.WriteLine(first.name);

            // a라는 이름으로 정수형변수를 선언하세요
            //int a = 10;

            FirstClass second = new FirstClass("JungSeok", 20);
            Console.WriteLine(second.name);
        }
    }
}
