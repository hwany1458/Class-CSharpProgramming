namespace WhileBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수를 선언합니다.
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            // 반복을 수행합니다.
            while (i < intArray.Length)
            {
                // 출력합니다.
                Console.WriteLine(i + "번째출력:" + intArray[i]);

                // 탈출을 위해 변수를 더합니다.
                i++;
            }
        }
    }
}
