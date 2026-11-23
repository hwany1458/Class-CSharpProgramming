namespace ConstructorOfStruct
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            Point point = new Point();

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
