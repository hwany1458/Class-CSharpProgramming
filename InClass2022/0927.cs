using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo k = Console.ReadKey();
            switch(k.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    Console.WriteLine("앞으로 전진"); break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    Console.WriteLine("뒤로 후퇴"); break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("좌로 이동"); break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    Console.WriteLine("우로 이동"); break;
                case ConsoleKey.Spacebar:
                    Console.WriteLine("점프"); break;
                default:
                    Console.WriteLine("다른 키를 눌렀습니다"); break;
            }


            
            // 키보드로부터 점수를 입력받아 학점을 출력하는 코드

            // (1) 입력받는 점수를 저장하기 위해 변수 선언
            int score;
            string str;  // 입력받는 문자열

            // C, scanf()
            // C#, Console.ReadLine()
            Console.Write("점수를 입력하세요 ");
            str = Console.ReadLine();
            score = int.Parse(str);

            // 점수를 학점으로 출력 -- if else if
            if ((90 <= score) && (score <= 100))
            { Console.WriteLine("A"); }
            else if ((80 <= score) && (score < 90))
            { Console.WriteLine("B"); }
            else if ((70 <= score) && (score < 80))
            { Console.WriteLine("C"); }
            else if ((60 <= score) && (score < 70))
            { Console.WriteLine("D"); }
            else
            { Console.WriteLine("F"); }

            // (1번)
            // 점수를 학점으로 출력 -- switch 
            // 여기에 작성 ...

            // ------------------------

            // 점수를 홀/짝 구분해서 출력 -- switch
            switch (score % 2)
            {
                case 0:
                    Console.WriteLine("짝수"); break;
                case 1:
                    Console.WriteLine("홀수"); break;
                default:
                    Console.WriteLine("뭘까요?"); break;
            }

            // (2번)
            // 점수를 홀/짝 구분해서 출력 -- if else
            // 여기에 작성 ...

            // -------------------

            // 삼항연산자
            Console.WriteLine(score % 2 == 0 ? "짝수입니다" : "홀수입니다");

            // (3번)
            // 오늘 날짜 (DateTime.Now)  -- month(월)
            // 봄여름가을겨울 -- if else if (지난 시간에)
            // 봄여름가을겨울 -- switch
            // 여기에 작성 ...

            int m = DateTime.Now.Month;
            Console.WriteLine($"현재 {m} 월입니다");
            switch (m)
            {
                case 3: 
                case 4: 
                case 5: Console.WriteLine("봄"); break;
                case 6: 
                case 7: 
                case 8: Console.WriteLine("여름"); break;
                case 9: 
                case 10: 
                case 11: Console.WriteLine("가을"); break;
                
                // case 12: Console.WriteLine("겨울"); break;
                //case 1: Console.WriteLine("겨울"); break;
                //case 2: Console.WriteLine("겨울"); break;
                
                default: Console.WriteLine("겨울"); break;
            }
            //----------------

            // 키보드로부터 이메일 주소를 입력받아, 
            // 이메일 형식이 맞는지 체크 (=) @가 포함되어 있는지 체크

            Console.Write("이메일 주소를 입력하세요 ");
            string email = Console.ReadLine();

            bool res = email.Contains("@");
            if (res)
            {
                Console.WriteLine("이메일주소 형식이 맞습니다. " + email);
            }
            else
            {
                Console.WriteLine("이메일주소 형식이 아닙니다.");
            }

        }
    }
}
