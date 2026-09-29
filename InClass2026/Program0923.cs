using System.Reflection;

namespace FirstProject
{
    internal class Program
    {
        // 전역변수
        int hp = 100;
        // var로 변수선언할 때는 전역변수 사용 못함
        //var num = 100;


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
            Console.WriteLine(int.Parse(z)+100);
            // 123100: 문자열일때, 223: 정수일때

            // 변수선언 (예) int a;
            // 데이터형을 지정하지 않고 변수선언
            // (1) 꼭 초기화를 같이
            // (2) 지역변수로만 사용 가능
            // (3) 데이터형 변환 안됨
            var number = 10;
            number = (int)123.456;
            
            // in C, (=) printf(\n)
            Console.WriteLine(number);

            // in C, (=) scanf()
            Console.Write("사용자 입력]");
            string str = Console.ReadLine();

            if (str != null) {  // 널이 아닐때 동작

            Console.WriteLine(str+100);  //123100

            int score = int.Parse(str);
            Console.WriteLine(score+1);
            }
            else  // 널일때는 계산하지 않고 빠져나오기
            {
                Console.WriteLine("경고) 널값");
            }

        }

        // user-defined functions
        void XXXX()
        {

        }

    }
}
