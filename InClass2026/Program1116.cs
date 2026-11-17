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

        // 소멸자
        ~FirstClass()
        {
            Console.WriteLine("객체가 파괴됩니다. 필요한 정보를 백업받으세요");
        }

    }

    public class Box
    {
        // variables
        // public --> private 변경 (데이터 은닉)
        private int width;
        private int height;

        // 생성자 (가로, 세로를 입력으로 받는 생성자)
        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        // methods
        
        // 면적 구하는 메소드
        public int Area()
        {
            return this.width * this.height;
        }

        // 속성(변수)에 점연산자를 써서, 직접 읽거나 쓰지를 못함 (private으로 바꿔서)
        // 속성에 값을 쓰고 읽는 메소드를 만듬
        public int GetWidth() { return this.width; }
        public int GetHeight() { return this.height; }
        
        public void SetWidth(int w) 
        {
            // 함수로 값을 셋 시키면, 장점으로, 데이터 무결성을 유지할 수 있음
            if (w > 0) { this.width = w; }
            else { Console.WriteLine("가로길이는 음수가 될수 없습니다");  }
        }
        public void SetHeight(int h) 
        {
            if (h > 0) { this.height = h; }
            else { Console.WriteLine("세로길이는 음수가 될수 없습니다"); }
        }
        
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            // 11.16
            // 박스 객체 생성
            Box box = new Box(10, 20);

            // 누군가가 이렇게 하면?  (잘못된 데이터를 입력하게 되면?)
            // 변수에 값을 넣어줌 (write) -- set (stter 세터)
            //box.width = -10;  // 직접
            box.SetWidth(-15);  // 함수를 통해
                                // 속성(변수)에 점연산자를 사용해서 직접 값을 넣지 않고
                                // 함수를 이용하면, 잘못된 데이터를 걸러낼수 있음

            // 변수의 값을 읽어옴 (read)  -- get (getter 게터)
            // 가로
            Console.WriteLine("가로길이는 " + box.GetWidth());

            // 면적 구해서 출력
            int boxArea = box.Area();
            Console.WriteLine("박스면적은 " + boxArea);
            
        }
    }
}
