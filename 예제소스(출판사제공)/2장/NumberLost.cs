namespace NumberLost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // long 자료형을 int 자료형으로 변환합니다.
            long longNumber = 2147483647L + 2147483647L;
            int longToInt = (int)longNumber;
            Console.WriteLine(longToInt);
            // double 자료형을 int 자료형으로 변환합니다.
            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);
        }
    }
}
