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
            // 변수 사용방법  (1)변수 선언, (2) 값을 할당 (=)
            //int a = 10;

            // 배열 (선언, 값 입력)  []
            int[] arr = { 10, 20, 30, 40 };  // arr 이라는 이름으로 정수형 배열을 선언
            // in C, int arr[];
            Console.WriteLine(arr[1]);
            arr[2] = 100;

            // 어떤 결과가 나올까요? 인덱스번호 보다 큰 번호로 접근
            // 에러발생 -- 컴파일 오류는 아님, 런타임에러 (실행과정에서 에러가 발생)
            // Console.WriteLine(arr[4]);
            Console.WriteLine(arr.Length);

            // 원하는 크기만큼의 배열을 선언해서 쓸 때 (161페이지)
            int[] arrInt = new int[10];
            Console.WriteLine(arrInt[5]);
            arrInt[0] = 123;
            Console.WriteLine(arrInt[0]);

            // (앞에서 선언한) 정수배열을 하나씩 모두 (가지고 와서) 출력
            // arr : 데이타가 4개 (반복회수 = 4)  -- for문 유리
            // for 문법 : for(초기식; 조건식; 종결식) {}
            // 체크할 것 : 인덱스번호 보다 큰 회수로 반복할 경우 -- 런타임 오류
            // 권장 : 반복문을 처리하기 전에, 반복회수를 체크해서 (그만큼만) 반복하세요.
            //for (int i = 0; i < 4; i++)
            for (int i = 0; i < arr.Length; i++)  // 인덱스번호 : 0, 1, 2, 3
            {
                Console.WriteLine(i + "번째 데이타는 " + arr[i]);
            }

            // 역for : 인덱스번호 : 3, 2, 1, 0
            for (int i = (arr.Length-1); i >=0; i--)
            {
                Console.WriteLine(i + "번째 데이타는 " + arr[i]);
            }

        }
    }
}
