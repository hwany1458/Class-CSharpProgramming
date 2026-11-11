namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11.02.
            // Math클래스
            // 객체 생성하지 않고 사용 (=) new 명령없이 점연산자를 바로 사용
            int intResult = Math.Abs(-10);
            int intMax = Math.Max(10, 20);

            Console.WriteLine(intResult);
            Console.WriteLine(intMax);
            
            // (1) 5개 랜덤 정수(1~100)를 뽑아서, 리스트에 추가 -- 반복문 사용 (for)
            // (2) 리스트 중에서 최대값, 최소값을 추출  -- 반복 (foreach)
            // (3) 출력

            // 변수 선언
            Random random = new Random();
            List<int> list = new List<int>();
            int intRandom;

            // (1)
            for (int i = 0; i < 5; i++) 
            { 
                intRandom = random.Next(1, 101);
                list.Add(intRandom);
            }

            // (2)
            int iMax = -100;
            int iMin = 1000;
            foreach (var item in list)
            {
                iMax = Math.Max(item, iMax);
                iMin = Math.Min(item, iMin);
            }

            // (3)
            Console.WriteLine("리스트에 있는 값들은 " + string.Join(", ", list));
            Console.WriteLine("최대값은 " + iMax);
            Console.WriteLine("최소값은 " + iMin);

        }
    }
}
