namespace Methods
{
    internal class Program
    {
        // 코드 6-2: 두 개의 매개변수를 갖는 메서드
        class Test1
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
        }

        // 코드 6-3: 아무것도 반환하지 않는 메서드
        class Test2
        {
            public void Print()
            {
                Console.WriteLine("Print() 메서드가 호출되었습니다.");
            }
        }

        static void Main(string[] args)
        {
            Test1 test1 = new Test1();
            Console.WriteLine(test1.Multi(52, 273));
            Console.WriteLine(test1.Multi(103, 32));

            Test2 test2 = new Test2();
            test2.Print();
            test2.Print();
            test2.Print();
        }
    }
}
