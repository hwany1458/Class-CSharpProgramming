namespace Constructors
{
    internal class Program
    {
        // 코드 6-16: 기본적인 생성자의 모습
        class Product
        {
            public string name;
            public int price;

            public Product(string name, int price)
            {           
                this.name = name;
                this.price = price;
            }
        }

        // 코드 6-18: private 생성자
        class Hidden
        {
            private Hidden() { }
        }

        // 코드 6-19: 정적 생성자
        class Sample
        {
            public static int value;

            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }
                
        static void Main(string[] args)
        {
            // 아래 행은 코드 6-18인데, 오류가 발생하므로 주석으로 처리합니다.
            // Hidden hidden = new Hidden();
            
            // 코드 6-20: 정적 생성자의 호출 시점
            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치"); 
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");
        }
    }
}
