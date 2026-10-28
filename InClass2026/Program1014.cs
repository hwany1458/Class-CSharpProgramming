using System;
using System.Reflection;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10.14.
            
            string str = "Hello world";
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());

            // (1) 키보드로부터 이메일주소를 입력받음
            // (2) id부분, 메일서버부분을 짤라서 (3) 출력
            // (4) 이메일주소형태로 입력하지 않은 경우, 오류메시지 출력

            //(1) ReadLine()
            Console.Write("이메일주소를 입력하세요. ");
            string email = Console.ReadLine();
            
            //(2)
            string[] inputStr = email.Split('@');

            //(4) 판별 -- 조건문(if문)
            // (4-1)키보드입력문자열 == 짤라낸문자열
            // (4-2)키보드입력문자열 길이 == 짤라낸문자열 길이
            // (4-3) 짤라낸문자열 인덱스 [1]이 있는지 없는지 구분
            //if (inputStr.Length == 2) // 잘 짤린 상태 (=)배열에 2개 데이터가 잘 들어간 상태
            if (email.Equals(inputStr[0]))  // (4-1)
            {
                //(3)
                Console.WriteLine("ID: " + inputStr[0]);
                Console.WriteLine("메일서버: " + inputStr[1]);
            }
            else
            {
                Console.WriteLine("이메일주소를 잘못 입력했습니다");
            }

            string[] strArray = { "원광대", "공학3계열", "게임콘텐츠전공", "1학년"};
            string temp = strArray[0] + strArray[1];
            Console.WriteLine(temp);
            
            // (반복문을 써서) 모두 합침
            string concateStr = "";
            foreach (string item in strArray)
            {
                concateStr = concateStr + " " + item;
            }
            Console.WriteLine(concateStr);

            // 함수를 써서 모두 합침
            string joinStr = string.Join(",", strArray);
            Console.WriteLine(joinStr);

        }
    }
}
