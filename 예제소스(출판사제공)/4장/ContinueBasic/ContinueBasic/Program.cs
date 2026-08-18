namespace ContinueBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //코드 4-24: continue 키워드
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            // 코드 4-25: [코드 4-24]를 간단하게 변경            
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
