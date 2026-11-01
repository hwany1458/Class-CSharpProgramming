namespace ClassUses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 5-3: 원하는 범위의 실수 난수 생성
            Random random = new Random();
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);


            // 코드 5-4: 배열 생성
            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];


            // 코드 5-5: List 클래스의 인스턴스 생성
            // 인스턴스를 생성합니다.
            List<int> list = new List<int>();
        }
    }
}
