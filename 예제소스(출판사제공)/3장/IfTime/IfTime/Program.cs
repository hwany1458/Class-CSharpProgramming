namespace IfTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 3-3: 현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);


            // 코드 3-4: 오전과 오후 구분하기
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }

            if (12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
