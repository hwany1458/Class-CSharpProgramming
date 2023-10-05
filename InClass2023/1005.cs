using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 이름 10번 출력하세요
            // for(초기식; 조건식; 종결식) { .. }
            // 4절
            for(int i=0; i<10; i++)
            { 
                Console.WriteLine(i+ "이용환[" + (i+1) + "번째]");
            }
            // 5절(역for)
            for(int i=10; i>0; i--)
            {
                Console.WriteLine(i + "이용환[" + (11 - i) + "번째]");
            }

            // 중첩for문 (중첩반복문)
            for (int i=0; i<10; i++)
            {
                //Console.WriteLine("**********");
                for (int j=0; j<10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            // 배열 : 동일한 데이타타입을 묶어서 처리할 때
            // 예) 정수형 변수 선언, 값할당
            int a = 10;
            // 예) 정수형 배열 선언
            int[] b = { 10, 20, 30 } ;
            // in C, int b[] = { 10, 20, 30 } ;
            // 배열(내의) 원소에 접근하려면 [인덱스번호] 로 접근가능
            Console.WriteLine(b[1]);
            b[2] = 100;

            string[] str = {"밥", "못먹어요", "라면", "기식", "잠자느라못먹음" };
            Console.WriteLine(str[0]);

            // 배열은 2개이상 묶어서 처리하는 경우가 많기 때문에
            // 배열내의 모든 데이터를 (하나씩 가져와서) 처리하려면
            // 반복문을 사용함
            for(int i=0; i<5; i++)
            //for (int i=0; i<6; i++) 
            // 에러 확인 : 인덱스번호 이상으로 올라가면 컴파일오류X, 
            // 실행도중 오류 발생 (런타임에러) -- IndexOutOfRange ..
            // 반복문 실행 전에, 인덱스번호를 확인해서 반복실행하는 것이 바람직함
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
