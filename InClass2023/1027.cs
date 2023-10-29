using System;

namespace ConsoleApp2
{

    class Program  // Program 이라는 이름으로 클래스를 정의
    {
        // 속성


        // 기능
        static void Main(string[] args)
        {
            // 객체가 필요할 때, 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            Random obj1 = new Random();
            int dice1, dice2;

            // 주사위 10번 던지기
            for (int i = 0; i < 10; i++)
            { 
                dice1 = obj1.Next(1, 7);
                Console.WriteLine((i+1) + ":" + dice1);
            }

            // 주사위 2개를 던져서 나온 합만큼 칸수를 전진합니다
            dice1 = obj1.Next(1, 7);
            dice2 = obj1.Next(1, 7);
            Console.WriteLine("주사위1:" + dice1 + " 주사위2:" + dice2 + ", " + (dice1+dice2) + "칸 전진");

            Console.WriteLine(obj1.Next(100));

            Console.WriteLine("--------------------------");

            string inputStr;
            int inputNum, comNum;

            // 가위바위보
            do
            {
                // 다음 입력을 받기 위해
                Console.Write("[가위1, 바위2, 보3, 종료0] 숫자를 입력하세요 :");
                inputStr = Console.ReadLine();
                inputNum = int.Parse(inputStr);

                // 가위바위보 게임을 완성시키려면, 여기서 컴퓨터입력을 처리
                comNum = obj1.Next(1, 4);

                Console.WriteLine("입력한 값은 " + inputNum);
                // 숙제
                // 가위바위보의 승무패를 출력하세요
                // "몇승몇무몇패" 이놈을 출력함.
            } while (inputNum != 0);
        }  
    }
}
