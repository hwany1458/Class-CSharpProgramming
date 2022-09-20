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
            int a = 100;
            long b = 10000;

            // 데이타타입 변환  
            // (1) 숫자간에 변환
            // 정수-긴정수, 실수-긴실수, 실수-정수, 정수-실수 간...
            // (데이타타입)
            a = (int)b;    
            // int 범위내의 숫자라서 정상적으로 잘 들어감 (10,000)
            // int 범위 외의 숫자는 어떻게 될까요?
            // 10,000,000,000 (백억은?) 
            // 에러는 나지 않지만, 원하지 않는 수로 표시됨 (overflow)

            Console.WriteLine(a);

            // 다른 데이터형에서 숫자로 변환
            Console.WriteLine(int.Parse("1000"+1)+1);
            Console.WriteLine(double.Parse("3.4")+1.0);

            // 다른 데이터형에서 문자열로 변환
            Console.WriteLine(100.ToString()+1);

            // PPT 65페이지 퀴즈 풀어서 제출

            // ------------------------------
            // C에서, printf("값은 %d %f", 100);
            // 형식지정자, 형식표현자  %d, %f, %c, %s
            // C#에서도
            int x = 100;
            Console.WriteLine("값은 {0}, {1}", 100, x);

            // 형식표현자가 많은 경우 - {} 3개, 매개변수 2개
            //Console.WriteLine("값은 {0}, {1}, {2}", 100, x);
            // 컴파일 에러 안남, 실행중 오류 발생

            // 형식표현자가 적은은 경우 - {} 2개, 매개변수 3개
            Console.WriteLine("값은 {0}, {1}", 100, x, 2000);
            // 컴파일 에러 안남, 실행 중 오류 없음, 남는 매개변수는 무시

            // C#에서는 $""
            string name = "닭꼬치";
            int price = 4000;
            Console.WriteLine($"{name} is {price}");
        }
    }
}
