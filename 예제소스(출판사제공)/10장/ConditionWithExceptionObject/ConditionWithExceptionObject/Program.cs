namespace ConditionWithExceptionObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력: ");

            // 코드 10-8: 예외 상황 확인
            /* string input = Console.ReadLine();
            int[] array = { 52, 273, 32, 103 };

            int index = int.Parse(input);
            Console.WriteLine("입력 숫자: " + index);
            Console.WriteLine("배열 요소: " + array[index]); */

            // 코드 10-9: 고급 예외 처리
            try
            {
                string input = Console.ReadLine();
                int[] array = { 52, 273, 32, 103 };

                int index = int.Parse(input);
                Console.WriteLine("입력 숫자: " + index);
                Console.WriteLine("배열 요소: " + array[index]);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("FormatException 발생");
                Console.WriteLine(exception.GetType() + "이 발생했습니다.");
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("IndexOutOfRangeException 발생");
                Console.WriteLine(exception.GetType() + "이 발생했습니다.");
            }
        }
    }
}
