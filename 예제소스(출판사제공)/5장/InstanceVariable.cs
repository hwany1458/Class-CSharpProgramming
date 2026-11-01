namespace InstanceVariable
{
    internal class Program
    {
        // 코드 5-12: 인스턴스 변수 생성과 사용
        class Product
        {
            public string name;
            public int price;
        }

        
        // 코드 5-13: 인스턴스 변수 사용
        static void Main(string[] args)
        {
            // 인스턴스를 생성합니다.
            Product product = new Product();

            // 인스턴스 변수를 변경합니다.
            product.name = "감자";
            product.price = 2000;

            // 인스턴스 변수를 출력합니다.
            Console.WriteLine(product.name + " : " + product.price + "원");
        }
    }
}
