namespace InterfaceBasic
{
    internal class Program
    {
        // 코드 9-11: 인터페이스 상속
        // 코드 9-12: 인터페이스 구현
        class TestClass : IBasic
        {
            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }

            public int TestPreoperty 
            { 
                get => throw new NotImplementedException(); 
                set => throw new NotImplementedException(); 
            }
        }

        static void Main(string[] args)
        {
            // 코드 9-13: 인터페이스 다형성
            IBasic basic = new TestClass();
        }
    }
}
