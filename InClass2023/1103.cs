using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        static void Main(string[] args)
        {
            // 클래스 --> 객체 (인스턴스화)
            // 클래스 객체명 = new 클래스();
            //Random obj1 = new Random();
            //List<int> obj2 = new List<int>();

            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Min(10, 20));
            Console.WriteLine(Math.Max(10, 20));

            // 문제
            // 키보드로부터 5개 정수를 입력받아, 
            // 최대값과 최소값을 출력하세요
            // (1)키보드로부터 입력을 받음 (5개) -- 저장
            // 변수, 배열, 리스트
            // (2)(배열이나 리스트에서) 하나씩 가져와서
            // 현재 최소값, 최대값과 비교해서 받아줌(?)

            int[] arr = { 0, 0, 0, 0, 0 };
            string inputStr;
            //int inputNum,
            int minValue =100000000, maxValue=-100000000;

            for (int i=0; i<5; i++)
            { 
                Console.Write("정수를 입력하세요 ");
                inputStr = Console.ReadLine();
                /* (절차를 순서대로 애기하느라..)
                inputNum = int.Parse(inputStr);
                arr[i] = inputNum;
                */
                arr[i] = int.Parse(inputStr);
            }

            for(int j=0; j<5; j++)
            {
                // 어느 놈이 작은지를 판별 (최소값 뽑을려고)
                //if (arr[j] < minValue) { minValue = arr[j]; }
                minValue = Math.Min(arr[j], minValue);

                // 어느 놈이 큰지를 판별 (최대값 뽑을려고)
                //if (arr[j] > maxValue) { maxValue = arr[j]; }
                maxValue = Math.Max(arr[j], maxValue);
            }

            Console.WriteLine("최대값:" + maxValue + ", 최소값:" + minValue);
        }
    }
}
