namespace IncrementOperatorPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-42: 증감 연산자의 후위 형태
            int number1 = 10;
            Console.WriteLine(number1);
            Console.WriteLine(number1++);
            Console.WriteLine(number1--);
            Console.WriteLine(number1);

            // 코드 2-43: 증감 연산자의 전위 형태
            int number2 = 10;
            Console.WriteLine(number2);
            Console.WriteLine(++number2);
            Console.WriteLine(--number2);
            Console.WriteLine(number2);
        }
    }
}
