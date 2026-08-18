namespace SumWithFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수를 선언합니다.
            int output = 0;

            // 반복을 수행합니다.
            for (int i = 0; i <= 100; i++)
            {
                output += i;
            }

            // 출력합니다.
            Console.WriteLine(output);
        }
    }
}
