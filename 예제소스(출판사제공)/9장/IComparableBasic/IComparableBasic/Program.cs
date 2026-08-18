namespace IComparableBasic
{
    internal class Program
    {
        // 코드 9-2: IComparable 인터페이스 상속
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }

            public int CompareTo(object? obj)
            {
                // 코드 9-3: IComparable 인터페이스의 메서드 생성
                // throw new NotImplementedException();

                // 코드 9-4: ComparedTo() 메서드 구현
                return this.Price.CompareTo((obj as Product).Price);
            }
        }

        // 코드 9-1: 기본 클래스와 자료 생성
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500 },
                new Product() { Name = "사과", Price = 2400 },
                new Product() { Name = "바나나", Price = 1000 },
                new Product() { Name = "배", Price = 3000 }
            };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
