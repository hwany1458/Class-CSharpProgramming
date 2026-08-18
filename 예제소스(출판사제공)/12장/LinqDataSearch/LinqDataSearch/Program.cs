namespace LinqDataSearch
{
    internal class Program
    {
        // 코드 12-2: Linq를 사용해 간단하게 작성
        static IEnumerable<int> LinqSearch()
        {
            // 입력을 나타내는 리스트를 생성합니다.
            List<int> inputA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Linq 질의를 사용해 반환합니다.
            return from item in inputA
                   where item % 2 == 0
                   select item;
        }

        static void Main(string[] args)
        {
            // 코드 12-3: Linq 기본 구문
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var output = from item in input
                         where item % 2 == 0
                         orderby item
                         select item;

            // 출력
            foreach (var item in LinqSearch()) { Console.WriteLine(item); }
            Console.WriteLine();
            foreach (var item in output) { Console.WriteLine(item); }
        }
    }
}
