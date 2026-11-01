namespace Overloading
{
    internal class Program
    {
        // 코드 6-10: 메서드 오버로딩
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static double Abs(double input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static long Abs(long input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
        }

        // 코드 6-11: 오버로딩 불가
        // class TestWorld
        // {
        //     public int Test(int input) { }
        //     public double Test(int input) { }
        //     public double Test(int input) { }
        // }

        static void Main(string[] args)
        {
            // int
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            // double
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-32.103));
            
            // long
            Console.WriteLine(MyMath.Abs(21474836470));
            Console.WriteLine(MyMath.Abs(-21474836470));
        }    
    }
}
