namespace ForReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열을 생성합니다.
            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            // 배열의 길이를 출력합니다.
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
