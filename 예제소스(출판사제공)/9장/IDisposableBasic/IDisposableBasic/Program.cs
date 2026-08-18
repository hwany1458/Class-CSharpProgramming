namespace IDisposableBasic
{
    internal class Program
    {
        // 코드 9-6: IDisposable 인터페이스 상속
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                // 코드 9-7: IDisposable 인터페이스의 메서드 생성
                // throw new NotImplementedException();

                // 코드 9-8: Dispose( ) 메서드 구현 및 호출
                Console.WriteLine("Dispose() 메서드를 호출합니다.");
            }
        }

        static void Main(string[] args)
        {
            // 코드 9-8: Dispose( ) 메서드 구현 및 호출
            Dummy dummyA = new Dummy();
            dummyA.Dispose();

            // 코드 9-9: using 키워드와 IDisposable 인터페이스
            using (Dummy dummyB = new Dummy())
            {

            }
        }
    }
}
