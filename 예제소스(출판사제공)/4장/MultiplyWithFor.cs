namespace MultiplyWithFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수를 선언합니다.
            long output = 1;

            // 반복을 수행합니다.
            for (int i = 1; i <= 20; i++)
            {
                output *= i;
            }

            // 출력합니다.
            Console.WriteLine(output);
        }
    }
}
