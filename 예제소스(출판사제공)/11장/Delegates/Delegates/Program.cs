namespace Delegates
{
    // 코드 11-6: 델리게이터 생성 위치
    public delegate void TestDelegateA();

    internal class Program
    {
        public delegate void TestDelegateB();

        // 코드 11-7: 델리게이터 초기화 방법
        //public delegate void TestDelegateC();

        static void Main(string[] args)
        {
            TestDelegateA delegateA;
            TestDelegateB delegateB;

            /* TestDelegateA delegateA = TestMethod;
            TestDelegateB delegateB = delegate () { };
            TestDelegateC delegateC = () => { };

            delegateA();
            delegateB();
            delegateC(); */
        }

        static void TestMethod()
        {

        }
    }
}
