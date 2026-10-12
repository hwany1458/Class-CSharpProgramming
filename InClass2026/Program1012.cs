using System;
using System.Reflection;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10.12
            // for문을 사용해서, 1~10까지 출력하세요
            // (예, 순차번호:1,2,3,4   합계:1,3,6,10,15)
            int sum = 0;
            for (int i=1; i<=10; i++)
            {
                // 3의배수일때만 출력(번호, 합계)
                // 나머지연산 -- 0, 1, 2
                if ((i % 3 == 1) || (i % 3 == 2)) { continue; }
                sum = sum + i;   // sum += i;
                Console.WriteLine("순차번호:" + i + " 합계:" + sum);
            }

            // foreach 반복문 -- 컬랙션에서 각각 가져와서 하나씩 처리
            string[] strArray = { "정헌", "현태", "정수", "다은", "지민" };
            //foreach (string str in strArray)
            foreach (var str in strArray)
            {
                Console.WriteLine(str);
            }
            // for
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }

            // 응용예제2
            // 키보드로부터 사용자 입력받아,
            // ESC키를 누르면, 반복에서 빠져나옴 
            ConsoleKeyInfo consoleKeyInfo;

            //*** 
            //bool isPlaying = true;

            //-------------------------
            // 화살표키를 입력받아, 캐릭터 한칸 이동 (콘솔에 뿌려줌)
            do {

                Console.Write("화살표키를 이용해서 캐릭터를 이동하세요 ");
                consoleKeyInfo = Console.ReadKey();
                // 화살표키 
                // + WASD도 같이 동작하도록 수정해보세요
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("캐릭터를 한칸 앞으로 전진");
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("캐릭터 한칸 뒤로 후퇴");
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("캐릭터 왼쪽으로 한칸 이동");
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("캐릭터 오른쪽으로 한칸 이동");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("종료합니다");
                        //isPlaying = false;
                        break;
                    default:
                        Console.WriteLine("키를 잘못 눌렀습니다");
                        break;
                }
            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
            // while (isPlaying);
        }
    }
}
