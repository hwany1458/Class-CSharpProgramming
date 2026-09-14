namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 3-2: 중괄호 사용
            // 중괄호 사용 방식(1)
            if (true)
            {

            }
            // 중괄호 사용 방식(2)
            if (true) {

            }


            // 코드 3-9: 논리 연산자와 조건문
            // 학점 변수
            double score1 = 3.6;
            // 조건을 구분합니다.
            if (score1 == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score1 && score1 < 4.5)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score1 && score1 < 4.2)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= score1 && score1 < 3.5)
                Console.WriteLine("일반인");
            else if (2.3 <= score1 && score1 < 2.8)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= score1 && score1 < 2.3)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= score1 && score1 < 1.74)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= score1 && score1 < 1.0)
                Console.WriteLine("자벌레");
            else if (0 < score1 && score1 < 0.5)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");


            // 코드 3-10: 조건문 간단 사용
            // 학점 변수
            double score2 = 3.6;

            // 조건을 구분합니다
            if (score2 == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score2)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score2)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= score2)
                Console.WriteLine("일반인");
            else if (2.3 <= score2)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= score2)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= score2)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= score2)
                Console.WriteLine("자벌레");
            else if (0 < score2)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는􀗗혁명의 씨앗");


            // 코드 3-13: 조건 연산자
            int number = 52273;
            // 참과 거짓 위치에 불 자료형 사용
            Console.WriteLine(number % 2 == 0 ? true : false);
            // 참과 거짓 위치에 문자열 자료형 사용
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
        }
    }
}
