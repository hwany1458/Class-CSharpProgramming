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
            
            // 주사위 2번 던지기
            int randomNumber, randomNumber2 ;
            // 객체가 가지고 있는 속성(변수), 기능(메소드)는 점(.)연산자로 호출
            //randomNumber = obj.Next();
            //randomNumber = obj.Next(100);
            // min값을 포함, max값은 안포함
            // 주사위(1~6) : (1, 7)
            randomNumber = obj.Next(1, 6);
            randomNumber2 = obj.Next(1, 6);
            Console.WriteLine( (randomNumber+randomNumber2) + "칸 전진 [" + randomNumber + "," + randomNumber2 + "]");

            // 슬라이드 21
            // do while()문을 써서 반복 
            // int me, computer;
            // 만약 승무패를 계산하려면 int win, draw, lose;
            // do
            // {
            // 키보드로부터 입력 Console.ReadLine() -- 문자열 "1"
            // 숫자로 바꾸려면 int.Parse()
            // 컴퓨터에서 램덤 수를 뽑으려면 Random클래스 객체 생성 new
            // (예) Random objSPR = new Random();
            // 가위바위보 판결  if문, switch문을 써서 판별
            // 결과 출력 Console.WriteLine()
            // } while();


            //(2) List클래스 ----------------
            // 클래스 생성
            // 클래스 객체명 = new 클래스();
            List<int> objList = new List<int>();   // 정수 목록
            List<string> objList2 = new List<string>();   // 문자열 목록

            objList.Add(10);  // 아이템 추가
            for (int i=20; i<100; i+=10)
            {
                objList.Add(i);  // 추가
            }
            objList.Add(30);

            bool result;
            //result = objList.Remove(30);  // 아이템 제거 -- 있는 아이템은 잘 지워짐
            // result = objList.Remove(100);  // 아이템 제거 -- 없은 아이템 지워면 결과가 false

            result = objList.Remove(30);
            if (result) { Console.WriteLine("잘 지워짐"); }
            else { Console.WriteLine("잘 안지워짐");  }


            // 목록에 들어간 데이터를 보려면
            // objList.Count 세서 for()문을 반복 출력해도 되지만,
            // foreach(데이터타입 변수명 in 컬렉션)
            foreach(var item in objList)
            {
                Console.WriteLine(item);
            }

            // 배열
            // int[] arr = {10, 20, 30 }; // 선언 + 초기화(초기 데이터)
            // List클래스에서 objL 정수형 목록을 생성하면서 초기 데이터
            List<int> objL = new List<int>() { 1, 2, 3 };

            // 슬라이드 27 로또 대신에 ....
            // 랜덤 숫자(1~100사이 정수)를 19개 뽑아서, List<int>에 추가하고, 출력하기
        }
    }
}
