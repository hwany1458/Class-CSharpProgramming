using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 클래스 생성(5.3절)에서 설명
    class MyMath
    {
        public double PI = 3.14159265;

        // 라디안 - 디그리 변환 메소드
        public double rad2deg(double radian)
        {
            return radian * 180 / PI;
        }
        public double deg2rad(double degree)
        {
            return degree * PI / 180;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            // 클래스에서 객체를 생성해서 사용하는 방법
            // 클래스명 객체명 = new 클래스명();
            Random obj1 = new Random();

            // 객체명.메소드() 또는 객체명.변수  (점 연산자)
            int ranNum = obj1.Next(1, 4);

            // Math 클래스 -- new해서 객체를 만들지 않고 바로 사용
            int result = Math.Abs(-100);
            result = Math.Max(1, 2);
            result = Math.Min(1, 2);
            Console.WriteLine(result);

            // 삼각함수 (sin, cos, tan ..) 매개변수의 단위는 라디안
            // 도(degree)를 사용하려면,
            // 라디안 --> 디그리로 변환해서 사용해야 함
            
            // 여기서는 클래스생성을 생각하지 마세요.
            // 5.3절에서 설명 예정
            MyMath testObj = new MyMath();
            double temp = testObj.deg2rad(90.0);

            double res = Math.Sin(temp);
            Console.WriteLine(res);


            // PPT 31페이지
            // (1,2번)은 지난 시간에 나간 과제 내용임
/*
 * 슬라이드 27 로또 대신에 ....
 * 랜덤 숫자(1~100사이 정수)를 19개 뽑아서, List<int>에 추가하고, 출력하기
*/
            // (3번) 최대값, 최소값을 찾으려면 ..
            // int min=1000, max=0;  // 큰값, 작은값을 초기로 지정

            // foreach()를 써서 저장된 값들을 하나씩 가져와서
            // min과 max값을 하나씩 비교해서 작은값과 큰값으로 각각을 바꿔줌
            // 비교는 Math.Min() Math.Max()로 
        }
    }
}
