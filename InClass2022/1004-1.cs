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
            // while 반복문
            int i = 1;
            
            //while(true)  // 무한반복
            while (i <= 10)
            {
                Console.WriteLine("이용환 " + i);
                i++;
            }
            //--------------------

            // 키보드로부터 정수를 입력받아, 출력하기
            // 정수가 0이 아닐 때, 계속해서 입력을 받고
            // (만약 입력받은) 정수가 0이면 반복을 마치고 끝냄

            string inputStr;
            int inputNum;

            /*
            Console.Write("가위(1), 바위(2), 보(3), 종료(0)을 입력 ");
            inputStr = Console.ReadLine();
            inputNum = int.Parse(inputStr);
            */

            // while() {..} 조건을 체크해서 참일 때 실행
            // (만약) 조건이 처음부터 거짓이면 반복문을 실행하지 않음
            // do {..} while(); 먼저 한번을 실행한 다음, 조건을 체크

            //while(inputNum != 0)
            // while --> do while 으로 변경
            do
            {
                Console.Write("가위(1), 바위(2), 보(3), 종료(0)을 입력 ");
                inputStr = Console.ReadLine();
                inputNum = int.Parse(inputStr);

                Console.WriteLine($"입력받는 수는 {inputNum}");
            } while (inputNum != 0);


            // 숙제
            // 키보드로부터 화살표(또는 ASWD) 키를 입력받아서, 앞뒤좌우을 표시
            // 여기까지는 9월27일 코드 참조
            // 수정 -- 키보드로부터 ESC키를 입력받을 때까지 
            //         반복적으로 위의 내용을 수행
            // do while()문으로 작성합니다.

            //------------------------
            // 1~10까지 반복해서 출력해보세요
            // 수정 : 홀수만 출력하고 싶어요
            // (1) 2씩 증가하게 -- 시작이 짝수면 짝수가 출력 (좋은 방법 아님)
            for (int x = 1; x <= 10; x++)
            {
                // (2) 홀수인지를 체크해서 홀수인 경우만 출력
                if ((x % 2) == 0)
                {
                    // continue 일때와 break 일때의 차이를 확인하세요
                    continue;
                    //break;
                }
                Console.WriteLine(x);
            }
        }
    }
}
