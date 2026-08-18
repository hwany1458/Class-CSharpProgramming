namespace ClassMethods
{
    internal class Program
    {
        // 코드 6-8: 클래스 메서드에서 인스턴스 변수 사용은 오류가 발생
        // public int instanceVariable1 = 10;

        // 코드 6-9: 클래스 메서드에서는 클래스 변수 사용만 가능
        public static int instanceVariable2 = 10;

        static void Main(string[] args)
        {
            // Console.WriteLine("instanceVariable1");
            Console.WriteLine("instanceVariable2");
        }
    }
}
