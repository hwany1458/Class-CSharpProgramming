namespace ThrowBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 10-10: 예외 던지기 확인
            // throw new Exception();

            // 코드 10-11: 강제로 던진 예외의 예외 처리
            try
            {
                throw new Exception();
            }
            catch (Exception exception)
            {
                Console.WriteLine("예외가 발생했습니다.");
            }
        }
    }
}
