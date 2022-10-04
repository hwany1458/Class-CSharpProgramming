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
            // 배열 (선언, 값 입력)  []
            int[] arr = { 10, 20, 30, 40 };  // arr 이라는 이름으로 정수형 배열을 선언
            // in C, int arr[];
            Console.WriteLine(arr[1]);
            arr[2] = 100;

            for (int i = 0; i < arr.Length; i++)  // 인덱스번호 : 0, 1, 2, 3
            {
                Console.WriteLine(i + "번째 데이타는 " + arr[i]);
            }
            
            // 여기까지는 지난시간에 했던 내용
            //-----------------
            
            //foreach (int ele in arr)
            foreach (var ele in arr)
            {
                Console.WriteLine("가지고온 데이타는 " + ele);
            }

            string[] arrStr = { "없습니다", "스테이크", "초밥", "돈까스", "삼겹살소주", "소고기(한우++)" };
            //foreach(string s in arrStr)
            // foreach()에서 자료형은 데이터가 들어가는 시점에서 결정하는 var로 선언하도록 
            foreach (var s in arrStr)   // --- C#스럽게
            {
                Console.WriteLine(s);
            }

            // for문  (동작은 똑같음)  --- C스럽게
            for(int i=0; i<arrStr.Length; i++)
            {
                Console.WriteLine(arrStr[i]);
            }
        }
    }
}
