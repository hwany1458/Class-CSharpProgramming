using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Main() 함수는 시작위치, 반드시 하나가 있어야 함
        static void Main(string[] args)
        {
            // in C
            // printf("Hello, world");
            // 다음줄로 넘길려면 "\n"
            // 명령 끝나면 세미콜론(;) 붙임

            // in C#
            // C와 마찬가지로, 명령이 끝나면 세미콜론(;)을 붙어야 함.
            // 대소문자를 구분함
            Console.WriteLine("Hello, world.");

            // Console.WriteLine() = printf("\n") -- 기본적으로 한줄 넘어감
            // Console.Write() = printf("")
            // Console.Write() -- "\n"을 넣으면 그위치에서 한줄 넘어감

            // 주석처리는 C와 동일
            /* 주석  */
        }
    }
}
