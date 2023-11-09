using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class3
    {
        static void Main(string[] args)
        {
            // 클래스에서 객체를 인스턴스화 
            // 클래스 객체명 = new 클래스();
            Random obj1 = new Random();
            int randomNum = obj1.Next(1, 7);

            List<string> obj2 = new List<string>();
            obj2.Add("이용환");

            // Math는 따로 객체생성하지 않고 바로 클래스에 적용
            int largerNum = Math.Max(10, 20);

            // 임의의 수를 입력받아 절대값을 출력하세요
            Console.Write("임의의 수를 입력하세요 ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            // (1)  -- C스럽게
            // 양수인지 음수인지 판별해서 출력
            int absNnm;
            if (number >= 0) { 
                absNnm = number; 
            }
            else {
                absNnm = -number;
            }
            Console.WriteLine("[if사용] 절대값=" + absNnm);

            // (2) -- C#스럽게
            // Math클래스를 사용해서 출력
            int absNumber = Math.Abs(number);
            Console.WriteLine("[Math클래스사용] 절대값=" + absNumber);
        }
    }
}
