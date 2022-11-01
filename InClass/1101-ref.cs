using System;

namespace ConsoleApp1
{
    class TestClassEx
    {
        public void AccessPrivateMethod()
        {
            // Main() 은 private로 선언되어 있기 때문에, 외부 클래스에서 접근이 불가
            //Program.Main(new string[] { "Possible to access?" });
            Program.PublicPrint();
        }
        public TestClassEx()
        {
            Console.WriteLine("Constructor is called ..");
        }
        public TestClassEx(string str)
        {
            Console.WriteLine("Constructor " + str);
        }
        ~TestClassEx()
        {
            Console.WriteLine("Destructor is called ...");
        }
    }

    class MyMath
    {
        public static int absol(int input)
        {
            if (input < 0) return -input;
            else return input;
        }
        public static double absol(double input)
        {
            if (input < 0.0) return -input;
            else return input;
        }

        public static double absol(float input)
        {
            if (input < 0.0f) return -(double)input;
            else return (double)input;
        }
    }

     class Program
    {
        class TestClassIn
        {
            public void AccessPrivateMethod()
            {
                Program.Main(new string[] { "Possible to access?" });
                Program.PublicPrint();
            }
        }

        static void Main(string[] args)
        {
            TestClassEx obj1 = new TestClassEx();
            TestClassEx obj2 = new TestClassEx("with message");
        }
        public static void PublicPrint()
        {
            Console.WriteLine("Public static method is called ...");
        }
    }
}
