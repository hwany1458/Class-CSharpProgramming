using System.Data;

namespace Copies
{
    internal class Program
    {
        // 코드 6-32: 참조 복사의 예
        class Test
        {
            public int value = 10;
        }

        static void Change2(Test input)
        {
            input.value = 20;
        }
                
        // 코드 6-30: 값 복사의 예
        static void Change1(int input)
        {
            input = 20;
        }

        static void Main(string[] args)
        {
            int a1 = 10;
            Change1(a1);
            Console.WriteLine(a1);

            // 코드 6-31: 간단한 값 복사의 예
            int a2 = 10;
            int input = a2;
            input = 20;
            Console.WriteLine(a2);

            // 코드 6-32: 참조 복사의 예
            Test test = new Test();
            test.value = 10;
            Change2(test);

            Console.WriteLine(test.value);

            // 코드 6-33: 간단한 참조 복사의 예
            Test testA = new Test();
            Test testB = testA;
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine(testA.value);
        }
    }
}
