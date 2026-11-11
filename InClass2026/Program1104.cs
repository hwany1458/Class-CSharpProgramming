namespace SecondProject
{
    // 접근권한자 class 클래스명 {}
    // 위치(1) -- 클래스 밖에 선언
    public class FirstClass
    {

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

    }

    internal class Program
    {
        // 위치(2)
        public class SecondClass
        {

        }

        static void Main(string[] args)
        {
            // 11.04.
            // 클래스타입 객체명 = new 생성자();
            //Car car = new Car();
            Random random = new Random();

            FirstClass firstClass = new FirstClass();
            SecondClass secondClass = new SecondClass();
            ThirdClass thirdClass = new ThirdClass();

            // 절대값
            int res = Math.Abs(10);
            Console.WriteLine(res);

            // 뿡어빵 객체 생성
            FishShapedPastry fishShapedPastry = new FishShapedPastry();
            fishShapedPastry.amount = 1000;
            fishShapedPastry.name = "원광붕어빵";
            //fishShapedPastry.err = true;
            // "보호수준때문에 XXX에 액세스할수 없습니다"

        }
    }
}
