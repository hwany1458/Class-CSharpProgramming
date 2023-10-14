using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main(string[] args)
        {
            // 키보드로부터 정수값(inputNum)을 하나 입력받아서,
            // 1~inputNum 까지 반복하면서 숫자 출력
            // (수정1) 위 내용을 수정해 보세요 ... (홀수만 출력되도록)
            //    (A1) 반복문 안에 조건식을 넘는다 
            //         (홀수인지 판별해서 맞을 경우 출력, 안맞으면 안 출력)

            // (0) 변수선언
            // (1) 입력받기
            // (2) 조건체크해서 (출력을) 반복 

            // (0) 2개 정도
            string str;
            int inputNum;

            // (1)
            Console.Write("정수를 입력하세요 ");  // 선택적으로
            str = Console.ReadLine();
            inputNum = int.Parse(str);

            // (2) for(초기식; 조건식; 종결식)
            for(int i = 1; i <= inputNum; i++)
            {
                // 전부 출력
                //Console.WriteLine(i);

                // (A1)
                //if ((i%2) == 1)  // 홀수만 체크해서 출력
                if ((i % 2) != 1)  // 짝수만 체크 (= 홀수가 아닌지를 체크)
                {
                    // 확인하기 위해 출력해 본거고 ..
                    //Console.Write("[짝수] 안출력");
                    //continue;
                    // continue문을 만나면 현재 반복하고 있는 부분을 빠져나오고
                    // 다음 반복으로 넘어감

                    // (수정2) continue문을 break문으로 바꿔서 돌려봄
                    break;
                    // break문을 만나면 현재 반복하고 있는 부분을 빠져나오고
                    // 더 이상 반복을 하지 않음
                }
                Console.WriteLine(i);
            }
        }
    }
}
