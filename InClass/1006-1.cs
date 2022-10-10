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
            // 제공되는 클래스를 사용
            // (1) Random 클래스
            // 클래스에서 객체 생성하는 방법
            // 클래스이름 객체이름 = new 클래스이름(); 

            // obj라는 이름으로 Random 클래스에서 객체를 생성
            Random obj = new Random();
            int randomNumber;
            // 객체가 가지고 있는 속성(변수), 기능(메소드)는 점(.)연산자로 호출
            randomNumber = obj.Next();
            randomNumber = obj.Next(100);
            randomNumber = obj.Next(1, 100);
            Console.WriteLine(randomNumber);
        }
    }
}
