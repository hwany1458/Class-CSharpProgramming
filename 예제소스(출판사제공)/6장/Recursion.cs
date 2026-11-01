namespace Recursion
{
    // 코드 6-35: 재귀 메서드를 사용한 피보나치 인스턴스 메서드
    class Fibonacci1
    {
        public long Get(int i)
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }
    
    // 코드 6-36: 재귀 메서드를 사용한 피보나치 클래스 메서드
    class Fibonacci2
    {
        public static long Get(int i)
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
            if (i == 2) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 6-34: 재귀 메서드
            // 자기 자신을 호출하여 종료되지 않으므로 주석으로 처리합니다.
            // Main(new string[0]);

            // 코드 6-35: 재귀 메서드를 사용한 피보나치 인스턴스 메서드
            Fibonacci1 fibo1 = new Fibonacci1();
            Console.WriteLine(fibo1.Get(1));
            Console.WriteLine(fibo1.Get(2));
            Console.WriteLine(fibo1.Get(3));
            Console.WriteLine(fibo1.Get(4));
            Console.WriteLine(fibo1.Get(5));

            // 코드 6-36: 재귀 메서드를 사용한 피보나치 클래스 메서드
            Console.WriteLine(Fibonacci2.Get(1));
            Console.WriteLine(Fibonacci2.Get(2));
            Console.WriteLine(Fibonacci2.Get(3));
            Console.WriteLine(Fibonacci2.Get(4));
            Console.WriteLine(Fibonacci2.Get(5));
            }
    }
}
