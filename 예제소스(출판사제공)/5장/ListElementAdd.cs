namespace ListElementAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 5-6: 리스트 요소 추가
            // 인스턴스를 생성합니다.
            List<int> list1 = new List<int>();

            // 리스트에 요소를 추가합니다.
            list1.Add(52);
            list1.Add(273);
            list1.Add(32);
            list1.Add(64);

            // 반복을 수행합니다.
            foreach (var item in list1)
            {
                Console.WriteLine("Count: " + list1.Count + "\titem: " + item);
            }


            // 코드 5-7: List 인스턴스 생성과 동시에 요소 추가
            // 인스턴스를 생성합니다.
            List<int> list2 = new List<int>() { 52, 273, 32, 64 };

            // 반복을 수행합니다.
            foreach (var item in list2)
            {
                Console.WriteLine("Count: " + list2.Count + "\titem: " + item);
            }
        }
    }
}
