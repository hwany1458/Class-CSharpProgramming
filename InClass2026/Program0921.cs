using System.Reflection;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 09.21.
            // 복합연산자 (+=)
            int aa = 10;  // aa라는 이름으로, 정수형 변수를 선언하고, 초기값으로 10을 할당해라
            aa += 20;   // (=) aa = aa + 20;
            Console.WriteLine(aa);

            string bb = "공학3계열";
            bb += " 게콘";  // (=) bb = bb + "OOO";
            Console.WriteLine(bb);

            bb += aa;
            Console.WriteLine(bb);

            Console.WriteLine(aa++);
            Console.WriteLine(++aa);

            // 자료형 변환
            // 자동변환 vs. 강제변환 
            // 강제: (변환하려는 데이터형)변수/값

            int x = 100;
            long xx = 1000L;
            float y = 1.9f;
            double yy = 3.4;

            // int -> double (자동변환)
            yy = x;  // x를 yy에 넣으세요
            Console.WriteLine(yy);

            // float -> int (강제변환)
            x = (int)y;  // 소수점 아래는 버림
            Console.WriteLine(x);

            string z = "123";
            string zz = "WKGC";
            Console.WriteLine(z+100);

            // int -> string : ToString()
            zz = zz + x.ToString();
            Console.WriteLine(zz);
            // string -> int : Parse()
            // 다음시간에 ...


            // I'll be back~

            // 변수선언 (예) int a;
            // 데이터형을 지정하지 않고 변수선언
            // (1) 꼭 초기화를 같이
            var number = 100;
            Console.WriteLine(number);
        }
    }
}
