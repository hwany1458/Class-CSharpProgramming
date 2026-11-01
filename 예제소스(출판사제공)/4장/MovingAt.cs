using System;
using System.Threading;

namespace MovingAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 4-30: Console.SetCursorPosition() 메서드
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");

            Console.WriteLine();


            // 코드 4-31: Thread.Sleep() 메서드
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");


            // 코드 4-32: 이동하는 달팽이
            int x = 1;
            while (x < 50)
            {
                // 화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                // 출력합니다.
                if (x % 3 == 0)
                    Console.WriteLine(" __@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                // 100밀리초 정지하고 x를 증가시킵니다.
                Thread.Sleep(100);
                x++;
            }
        }
    }
}
