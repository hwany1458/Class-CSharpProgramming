namespace DirectTypeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265L).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());
        }
    }
}
