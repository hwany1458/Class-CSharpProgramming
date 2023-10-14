using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main1111(string[] args)
        {
            int[] distinctLook = { 7, 5, 4, 17, 8, 44 };

            //for (초기식; 조건식; 종결식) {}

            int cnt = 0;  // 초기식
            while (cnt < distinctLook.Length)   // 조건식
            {
                Console.WriteLine(distinctLook[cnt]);
                cnt++;  // 종결식
            }

            // 앞의 while() 반복문을 for()문으로 변경해 보세요
            for(int idx=0; idx < distinctLook.Length; idx++)
            {
                Console.WriteLine(distinctLook[idx]);
            }

            Console.WriteLine("-------------------");
            // 키보드부터 정수를 입력하고 (해당숫자를) 출력하는 코드를 작성하세요
            // 입력받은 정수가 0이 아니면 계속 반복
            // 0이면 반복을 빠져나옴

            // (1) while반복문 사용
            int inputNum = 0;   // 입력받은 정수 
            // (초기값을 임의의 정수로 넣어줌)

            // 초기값이 만약 0으로 지정했다면 어떻게 될까요?
            // 초기값에 따라서, 조건문이 false가 되면, 
            // 반복명령을 한번도 실행하지 않고 통과해 버림
            
            string inputStr;  // 입력받은 문자열

            // while --> do while으로 변경
            do
            {
                // 다음 입력을 받기 위해
                Console.Write("[가위1, 바위2, 보3, 종료0] 숫자를 입력하세요 :");
                inputStr = Console.ReadLine();
                inputNum = int.Parse(inputStr);
                // 가위바위보 게임을 완성시키려면, 여기서 컴퓨터입력을 처리
                Console.WriteLine("입력한 값은 " + inputNum);
            } while (inputNum != 0);

            /* 
            while(true)
            {
                // 반복하는 명령에서 조건을 거짓으로 만드는 것이 없을 경우, 무한반복
                Console.WriteLine("사랑해");
            }
            */
        }
    }
}
