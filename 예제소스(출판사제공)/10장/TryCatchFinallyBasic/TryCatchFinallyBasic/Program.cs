namespace TryCatchFinallyBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 10-3: 예외 상황 확인
            Console.Write("입력: ");
            string input = Console.ReadLine();

            // int index = int.Parse(input);
            // Console.WriteLine("입력 숫자: " + index);

            // 코드 10-4: 고급 예외 처리
            try
            {
                int index = int.Parse(input);
                Console.WriteLine("입력 숫자: " + index);
            }
            catch (Exception exception)
            {
                Console.WriteLine("예외가 발생했습니다.");
                Console.WriteLine(exception.GetType());
            }
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다.");
            }
        }
    }
}
