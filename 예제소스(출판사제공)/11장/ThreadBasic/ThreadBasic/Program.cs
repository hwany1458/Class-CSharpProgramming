namespace ThreadBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 11-10: Thread 클래스의 인스턴스 생성
            /* Thread threadA = new Thread(TestMethod);
            Thread threadB = new Thread(delegate ()
            {

            });
            Thread threadC = new Thread(() => {

            }); */

            // 코드 11-11: 스레드 실행
            Thread threadA = new Thread(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("A");
                }
            });
            Thread threadB = new Thread(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("B");
                }
            });
            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });

            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

        /* public static void TestMethod()
        {

        } */
    }
}
