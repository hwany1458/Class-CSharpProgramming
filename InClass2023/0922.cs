using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수(0~100)를 입력받아서, 학점(A,B,C,D,F) 출력
            int score;
            string credit;  // ABCDF -> char
            string inStr;

            Console.Write("점수를 입력하세요 ");
            // 키보드로부터 입력받음 (문자열)
            inStr = Console.ReadLine();
            // 문자열을 정수로 변환 
            score = int.Parse(inStr);
            // 점수로 학점 판단
            if (score >= 90) { credit = "A"; }
            else if ((80 <= score) && (score < 90)) { credit = "B"; }
            else if ((70 <= score) && (score < 80)) { credit = "C"; }
            else if ((60 <= score) && (score < 70)) { credit = "D"; }
            else { credit = "F"; }

            // A B C D F (현재)
            // A+ A B+ B C+ C D+ D F (이렇게 나오도록 수정해 보세요) 각자

            Console.WriteLine("입력한 " + score + "는 " + credit + "입니다");


            // 정수 입력, 홀수? 짝수?? 판별해서 출력
            Console.Write("(홀/짝 구분하는) 정수를 입력하세요 ");
            // 입력받을 문자열, 변환하는 정수 -- 변수 선언
            // 따로 변수선언X -- 앞에서 선언한 변수를 그대로 사용
            inStr = Console.ReadLine();
            score = int.Parse(inStr);

            switch (score % 2)
            {
                case 0:
                    Console.WriteLine("입력받은 수는 짝수");
                    break;
                case 1:
                    Console.WriteLine("입력받은 수는 홀수");
                    break;
                default:
                    Console.WriteLine("짝수/홀수 아닙니다");
                    break;
            }
            // (앞에서 작성한) 점수 -- 학점 출력하는 부분 (if else if로 작성됨)
            // 이놈을 switch문으로 바꿔 보세요

            // (앞에서 작성한) 정수 -- 홀/짝? 출력
            // 교재에서
            Console.WriteLine((score % 2 == 0) ? "짝" : "홀");
            
            credit = ((score % 2) == 0) ? "짝수" : "홀수";
            // 이놈을 if else문으로 바꿔 보세요 -- 각자
            Console.WriteLine(credit);

        }
    }
}
