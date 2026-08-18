namespace IfElseTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
