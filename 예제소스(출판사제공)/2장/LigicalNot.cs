namespace LigicalNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));
        }
    }
}
