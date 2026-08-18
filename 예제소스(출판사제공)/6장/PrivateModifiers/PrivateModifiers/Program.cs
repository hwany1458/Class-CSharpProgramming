namespace PrivateModifiers
{
    // 코드 6-13: 외부 클래스에서의 접근
    class Test
    {
        public void TestMethod()
        {
            Program.Main(new string[] { "" });
        }
    }

    internal class Program
    {
        // 코드 6-14: 내부 클래스에서의 접근
        class Test
        {
            public void TestMethod()
            {
                Program.Main(new string[] { "" });
            }
        }

        public void TestMethod()
        {
            Program.Main(new string[] { "" });
        }

        public static void Main(string[] args)
        {
            
        }
    }
}
