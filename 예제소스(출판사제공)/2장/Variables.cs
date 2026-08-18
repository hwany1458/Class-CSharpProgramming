namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-24: 오버플로
            int a1 = 2147483640;
            int b1 = 52273;
            Console.WriteLine(a1 + b1);

            Console.WriteLine();


            // 코드 2-27: uint와 ulong 자료형
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);

            Console.WriteLine();


            // 코드 2-28: int 자료형의 최댓값과 최솟값
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine();


            // 코드 2-29: long 자료형의 최댓값과 최솟값
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            Console.WriteLine();


            // 코드 2-32: sizeof 연산자
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));

            Console.WriteLine();


            // 코드 2-33: 문자 자료형과 연산자
            char a2 = 'a';
            char b2 = 'b';

            Console.WriteLine(a2 + b2);
            Console.WriteLine(a2 - b2);
            Console.WriteLine(a2 * b2);
            Console.WriteLine(a2 / b2);
            Console.WriteLine(a2 % b2);

            Console.WriteLine();


            // 코드 2-35: sizeof 연산자와 string 자료형
            // 오류가 발생하므로 주석으로 처리했습니다.
            // Console.WriteLine("string: " + sizeof(string));
        }
    }
}
