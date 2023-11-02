using System;

namespace ConsoleApp2
{
    class Program  // Program 이라는 이름으로 클래스를 정의
    {
        // 속성


        // 기능
        static void Main(string[] args)
        {
            // 가위바위보 (1판)
            // (1) 사용자(가위1, 바위2, 보3) -- 키보드로부터
            // (2) 컴퓨터(..) -- 랜덤하게 숫자를 뽑음 (Random 클래스 사용)
            // (3) 사용자낸수 vs. 컴퓨터낸수 -- 비교해서 승무패를 판정
            // (4) 결과 출력

            // 승무패 계산
            int win = 0;
            int draw = 0;
            int lose = 0;

            Console.Write("가위바위보를 입력하세요 (가위:1, 바위:2, 보:3) ");
            // (1)
            string inputStr = Console.ReadLine();
            int userInput = int.Parse(inputStr);

            // (2)
            // 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            Random obj = new Random();
            int comInput = obj.Next(1, 4);
            Console.WriteLine("컴퓨터 램던수 =" + comInput);

            // (3)
            if (userInput == 1)  // 사용자 = 1 (가위)
            {
                if (comInput == 1) // 컴 = 1 (가위)
                { Console.WriteLine("무승부"); draw++; }
                else if (comInput == 2)  // 컴 = 2 (바위)
                { Console.WriteLine("패"); lose++; }
                else  // 컴 = 3 (보)
                { Console.WriteLine("승"); win++; }
            } else if (userInput == 2) // 사용자 = 2 (바위)
            {
                if (comInput == 1) // 컴 = 1 (가위)
                { Console.WriteLine("승"); win++; }
                else if (comInput == 2)  // 컴 = 2 (바위)
                { Console.WriteLine("무승부"); draw++; }
                else  // 컴 = 3 (보)
                { Console.WriteLine("패"); lose++; }
            }
            else if (userInput == 3) // 사용자 = 3 (보)
            {
                if (comInput == 1) // 컴 = 1 (가위)
                { Console.WriteLine("패"); lose++; }
                else if (comInput == 2)  // 컴 = 2 (바위)
                { Console.WriteLine("승"); win++; }
                else  // 컴 = 3 (보)
                { Console.WriteLine("무승부"); draw++; }
            }
            else { Console.WriteLine("잘못 입력했습니다");  }

            Console.WriteLine(win + "승 " + draw + "무 " + lose + "패");

            // 숙제
            // do while() 을 사용해서 가위바위보 게임을 계속하게 수정
        }  
    }
}
