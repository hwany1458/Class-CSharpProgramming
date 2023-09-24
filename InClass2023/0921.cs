using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1)변수선언 <-- 정수 입력(키보드로부터)
            // (2) if문으로 홀수인지를 체크 (%연산 == 1)
            //    참이면 출력
            
            // (1)
            int inNum;  // inNum이라는 이름으로 정수형 변수룰 선언
            string inStr = Console.ReadLine();
            inNum = int.Parse(inStr);

            // (2)
            if ((inNum%2) == 1)
            {
                Console.WriteLine("입력한 " + inNum + "은 홀수입니다");
            }
            else
            {
                Console.WriteLine("입력한 " + inNum + "은 짝수");
            }

            // 입력받은 정수가 양수인지, 음수인지, 0인지를 조건문으로 체크해서 출력하세요
            if (inNum > 0) { Console.WriteLine("양수입니다"); }
            else {
                if (inNum < 0) { Console.WriteLine("음수"); }
                else { Console.WriteLine("입력받은 정수는 0입니다");  }
            }

            // 
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            // 시간을 정수로 받아냄
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

            // 지금시간이 오전인지, 오후인지를 출력하세요
            if ( hour < 12) { Console.WriteLine("오전"); }
            else { Console.WriteLine("오후"); }

            // (여, 예비역) 12시~2시 사이인지를 체크해서 점심식사시간을 표시하세요
            // (현역 남) 11:30 ~ 1:20 사이로 체크하기
            // 여, 예비
            if ((12 <= hour) && (hour < 14)) { Console.WriteLine("점심 먹으러 갑시다"); }
            else { Console.WriteLine("점심시간이 아닙니다"); }

            // 현역남
            /*
            switch(hour)
            {
                case 11:
                    if (30 <= minute) { Console.WriteLine("점심먹으러 갑시다"); }
                    else { Console.WriteLine("점심시간이 아닙니다"); }
                    break;
                case 12:
                    Console.WriteLine("점심먹으러 갑시다");
                    break;
                case 13:
                    if (20 >= minute) { Console.WriteLine("점심먹으러 갑시다"); }
                    else { Console.WriteLine("점심시간이 아닙니다"); }
                    break;
                default:
                    Console.WriteLine("점심시간이 아닙니다");
                    break;
            }
            // 현역 남학생은 위의 switch문을 중첩if문으로 바꾸세요
            */

            hour = 13; minute = 25;
            if (hour == 12) { Console.WriteLine("남:점심먹으러 갑시다"); }
            else {
                if (hour == 11 && 30 <= minute) { Console.WriteLine("남:점심먹으러 갑시다"); }
                else if (hour == 13 && 20 >= minute) { Console.WriteLine("남:점심먹으러 갑시다"); }
                else { Console.WriteLine("남:점심시간이 아닙니다"); }
            }

        }
    }
}
