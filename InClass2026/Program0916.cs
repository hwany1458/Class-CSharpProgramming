namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // in C,
            // printf("Hello, C\n");
            //Console.WriteLine("Hello, World!");
            //Console.Write("Hello, YongHwan");

            // 
            /* 주석은 C와 동일
             * */
            // 명령 끝은 ;
            // 대소문자 구별합니다

            // 09.16.
            //1.정수
            int a;   // a라는 (변수)이름으로 정수형 변수를 선언
            a = 100; // 100을 변수a에 할당(집어넣어라)
            // 오버플로우 났을때, 길 정수 long 
            Console.WriteLine(a);

            // 2.실수 (float, double)
            float b = 1.2f;  //  5f
            double c = 3.4;
            Console.WriteLine(b);
            Console.WriteLine(c);

            // 3.문자 
            char d = '가';   // 작은따옴표 -- 문자
            // in, C : 1바이트 처리하기 때문에 깨짐
            // in C#, 문제없이 출력됨 (2바이트로 처리)
            Console.WriteLine(d);

            //--------------
            // 4.문자열
            // in c, 문자열 : 문자 배열로 선언 []
            string e;   // e라는 (변수)이름으로 문자열 형태의 변수를 선언
            e = "원광대";  // 원광대 문자열을 변수e에 할당
            // 쌍따옴표 -- 문자열
            // 문자열 덧셈 -- 문자열을 (계속) 연결시킴
            Console.WriteLine(e + " 게콘");
            Console.WriteLine("HP: " + 100);  // 문자열+정수 -- 연결시켜줌

            // 5.부울
            bool isDead = false;  // isDead 라는 이름으로 부울형 변수를 선언 (값 할당)
            Console.WriteLine(isDead);

        }
    }
}
