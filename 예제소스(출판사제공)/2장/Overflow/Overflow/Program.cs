namespace Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-25: 오버플로            
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a + b);

            Console.WriteLine();


            // 코드 2-26: 자료형 변환을 사용한 해결 방법
            uint unsignedA = 2000000000;
            uint unsignedB = 1000000000;
            Console.WriteLine(unsignedA + unsignedB);
        }
    }
}
