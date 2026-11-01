namespace ClassMethod
{
    internal class Program
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input< 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
        }
    }
}
