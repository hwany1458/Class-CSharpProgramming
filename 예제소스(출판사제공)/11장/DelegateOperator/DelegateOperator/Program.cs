namespace DelegateOperator
{
    internal class Program
    {
        public delegate void SendString(string message);

        static void Main(string[] args)
        {
            SendString sayHello, sayGoodbye, multiDelegate;

            sayHello = Hello;
            sayGoodbye = GoodBye;

            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("윤인성");

            Console.WriteLine();

            multiDelegate -= sayGoodbye;
            multiDelegate("윤인성");
        }

        public static void Hello(string message)
        {
            Console.WriteLine("안녕하세요. " + message + " 씨...!");
        }

        public static void GoodBye(string message)
        {
            Console.WriteLine("안녕히 가세요. " + message + " 씨....");
        }
    }
}
