namespace GeneralDataSearch
{
    internal class Program
    {
        static List<int> GeneralSearch()
        {
            // 입력과 출력을 나타내는 리스트를 생성합니다.
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            // 입력을 나타내는 리스트에 반복을 적용합니다.
            foreach (var item in input)
            {
                // 조건을 확인합니다.
                if (item % 2 == 0)
                {
                    // 출력을 나타내는 리스트에 요소를 추가합니다.
                    output.Add(item);
                }
            }

            // 출력을 나타내는 리스트를 반환합니다.
            return output;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
