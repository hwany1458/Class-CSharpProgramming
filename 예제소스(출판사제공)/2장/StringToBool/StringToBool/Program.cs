namespace StringToBool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-70: 문자열을 불로 변환            
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));

            // 코드 2-71: int 자료형 최솟값의 음수
            int output = int.MinValue;
            Console.WriteLine(-output);
        }
    }
}
