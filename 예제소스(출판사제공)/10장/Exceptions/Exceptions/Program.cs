namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 10-5: finally 구문을 사용하지 않은 코드
            Console.Write("입력: ");
            string input = Console.ReadLine();

            try 
            {
                int index = int.Parse(input);
                Console.WriteLine("입력 숫자: " + index);
            }
            catch (Exception exception)
            {
                Console.WriteLine("예외가 발생했습니다.");
                Console.WriteLine(exception.GetType());
                return;
            }
            //Console.WriteLine("프로그램이 종료되었습니다.");
            
            // 코드 10-6: finally 구문 사용
            finally 
            {
                Console.WriteLine("프로그램이 종료되었습니다.");
            }
        }
    }
}