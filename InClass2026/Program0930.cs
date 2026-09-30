using System.Reflection;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 09.30.
            // XXX ? YYY : ZZZ
            // if (XXX) YYY else ZZZ
            int num = 101;
            Console.WriteLine(num % 2 == 0 ? "짝수입니다" : "홀수입니다");


            // 응용예제1
            // (1) 키보드로부터 소속기관을 입력받아, 문자열 저장
            // (2) 문자열 중에 "원광" 이 들어가 있는지 확인
            // (3) 확인결과를 출력
            Console.Write("소속기관을 입력하세요: ");
            string inputStr = Console.ReadLine();  // (1)
            // 사용자 입력을 잘 했는지 체크---
            if (inputStr == null || inputStr.Length == 0)
            {
                Console.WriteLine("입력하지 않았습니다");
            }
            else {

                bool result = inputStr.Contains("원광");  // (2)
                if (result)  // (3)
                {
                    Console.WriteLine("원광대학교 학생을 환영합니다.");
                }
                else
                {
                    Console.WriteLine("원광대 학생이 아니면 나가주세요..");
                }
            }

            // 응용예제2
            // 키보드로부터 사용자 입력받아,
            // ESC키를 누르면, 반복에서 빠져나옴 --- 반복문 학습 이후에 다시
            // 화살표키를 입력받아, 캐릭터 한칸 이동 (콘솔에 뿌려줌)
            Console.Write("캐릭터를 이동하세요 ");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            // 화살표키 
            // + WASD도 같이 동작하도록 수정해보세요
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.W: 
                case ConsoleKey.UpArrow:
                    Console.WriteLine("캐릭터를 한칸 앞으로 전진");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("캐릭터 한칸 뒤로 후퇴");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("캐릭터 왼쪽으로 한칸 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("캐릭터 오른쪽으로 한칸 이동");
                    break;
                default:
                    Console.WriteLine("키를 잘못 눌렀습니다");
                    break;
            }
        }
    }
}
