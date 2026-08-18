namespace StringAssignmentOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-39: 문자열과 관련된 복합 대입 연산자
            string output1 = "hello ";
            output1 += "world ";
            output1 += "!";

            Console.WriteLine(output1);

            Console.WriteLine();


            // 코드 2-40: 문자열과 관련된 복합 대입 연산자 예제 풀어쓰기
            string output2 = "hello ";
            output2 = output2 + "world ";
            output2 = output2 + "!";

            Console.WriteLine(output2);
        }
    }
}
