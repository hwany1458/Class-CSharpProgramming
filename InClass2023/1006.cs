using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main(string[] args)
        {
            string[] str = { "밥", "못먹어요", "라면", "기식", "바나나", "초코파이", "안먹었어요2", "물" };
            int[] arrInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // for문 
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine("------------------------");
            // foreach문
            //foreach(string item in str)
            foreach(var item in str)
            {
                Console.WriteLine(item);
            }

            // 누적합
            int sum = 0;
            //foreach (int a in arrInt)
            foreach (var a in arrInt)
            {
                sum += a;
            }
            Console.WriteLine("누적합=" + sum);

            // 변수선언할 때, 데이터타입 변수명;
            // var로 선언 (예, var aaa = "이용환";)

            //------------------------------------------
            int[] distinctLook = { 7, 5, 4, 17, 8, 44 };

            //for (초기식; 조건식; 종결식) {}

            int cnt = 0;  // 초기식
            while (cnt < distinctLook.Length)   // 조건식
            {
                Console.WriteLine(distinctLook[cnt]);
                cnt++;  // 종결식
            }

            // 앞의 while() 반복문을 for()문으로 변경해 보세요




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
