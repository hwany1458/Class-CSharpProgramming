namespace AssignmentOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-37: 숫자와 관련된 복합 대입 연산자
            int output1 = 0;
            output1 += 52;
            output1 += 273;
            output1 += 103;

            Console.WriteLine(output1);
            Console.WriteLine();

            // 코드 2-38: 숫자와 관련된 복합 대입 연산자 다른 방식
            int output2 = 0;
            output2 = output2 + 52;
            output2 = output2 + 273;
            output2 = output2 + 103;

            Console.WriteLine(output2);
        }
    }
}
