namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 4-9: 무한 반복
            // 무한 반복되면 뒤의 예제를 확인할 수 없으므로 주석으로 처리했습니다.
            // while (true)
            {
                Console.WriteLine("무한 반복");
            }


            // 코드 4-15: 시간을 사용한 반복문 이탈
            long start = DateTime.Now.Ticks;   // 변수를 선언합니다.
            long count = 0;

            // 반복을 수행합니다: 10000000Tick = 1초
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }

            Console.WriteLine(count + "만큼 반복했습니다.");   // 출력합니다.


            // 코드 4-23: goto 키워드
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto doNotUse;
                }
            }

        doNotUse:
            Console.WriteLine("goto 키워드");
        }
    }
}
