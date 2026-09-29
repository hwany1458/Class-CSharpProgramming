using System.Reflection;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 09.28.
            int playerHP = 100;

            // game started.
            // 옆구리, 옆구리, 머리,머리,머리,머리
            playerHP = 10;

            // 머리
            playerHP = 0;
            if (playerHP <= 0)
            {
                Console.WriteLine("플레이어가 사망했습니다. GAME OVER.");
            }
            //------------

            double successRate = 0.49;
            // 주사위 값으로 뭔가를 다르는 부분
            if (successRate >= 0.5)
            {
                Console.WriteLine("강화에 성공했습니다!");
            }
            else
            {
                Console.WriteLine("강화에 실패했습니다. 무기가 파괴되지 않았습니다.");
            }


            int score;
            //....게임하는 동안, score가 누적
            score = 1000;
            if (score >= 2000) { Console.WriteLine("마스터 랭크입니다"); }
            else if (2000 > score && score >= 1500) { Console.WriteLine("다이아몬드 랭크입니다"); }
            else if (1500 > score && score >= 1000) { Console.WriteLine("골드 랭크입니다"); }
            else { Console.WriteLine("실버 랭크입니다"); }

            // 숙제
            // 키보드로부터 정수를 입력받아서, -- ReadLine() -> int.Parse()
            // (1) 짝수인지, 홀수인지 출력하세요  -- if else 
            // (2) 양수인지, 0인지, 음수인지 출력하세요  -- if ..else if

            int a; // a라는 이름으로, 정수형 변수를 선언
            ConsoleKey inputKey = ConsoleKey.None;
            // .... 사용자 입력
            inputKey = ConsoleKey.UpArrow;

            switch (inputKey)
            {
                case ConsoleKey.UpArrow:
                    {
                        Console.WriteLine("위쪽으로 이동합니다."); break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        Console.WriteLine("아래쪽으로 이동합니다."); break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        Console.WriteLine("왼쪽으로 이동합니다."); break;
                    }
                case ConsoleKey.RightArrow:
                    {
                        Console.WriteLine("오른쪽으로 이동합니다."); break;
                    }
                default:
                    {
                        Console.WriteLine("잘못된 입력입니다."); break;
                    }
            }

            // 키보드로부터 정수(1~12)를 입력받아,
            // 계절(봄/여름/가을/겨울)을 출력하세요
            // 1~12 사이의 정수가 아니면, "입력 오류"를 출력
        }
    }
}
