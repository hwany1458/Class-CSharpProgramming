namespace ListElementRemove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 인스턴스를 생성합니다.
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            // 요소를 제거합니다.
            list.Remove(52);

            // 반복을 수행합니다.
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }
        }
    }
}
