namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // 10.28.

            // 제공하는 클래스에서 객체 생성
            // 클래스 객체명 = new 생성자();
            Random obj1 = new Random(); // 주사위1
            Random obj2 = new Random(); // 주사위2

            // obj1이라는 이름으로 Random 클래스 형태의 객체를 선언하고,
            // new 명령을 통해 객체를 생성해서 obj1에 대입

            // int a = 100;
            // a라는 이름으로 정수형 변수를 선언하고, 초기값으로 100을 a에 대입

            int randomInt1 = obj1.Next(1,7);
            int randomInt2 = obj2.Next(1, 7);
            Console.WriteLine("1번 주사위=" + randomInt1);
            Console.WriteLine("2번 주사위=" + randomInt2);
            Console.WriteLine((randomInt1 + randomInt2) + "칸 전진");

            // 가위바위보 게임--
            // 가위(1), 바위(2), 보(3)으로 결정하고,
            // 플레이어는 키보드로부터 입력을 받음
            // 컴퓨터는 랜덤값을 뽑아냄 (Random 클래스를 사용해서 1~3) <---

            // List 클래스
            List<int> listObj = new List<int>();
            // 배열에서 첫번째 위치에 데이터 10을 넣고싶어
            // arrayInt[0] = 10;
            listObj.Add(100);
            // 리스트에 10, 20, 30, 40, 50 을 넣고싶어요. how?
            for (int i = 10; i <= 50; i += 10)
            {
                listObj.Add(i);
            }
            listObj.Add(10);

            // List 객체에 들어가있는 데이터를 출력하고 싶어요. how?
            Console.WriteLine("지우기전");
            foreach (int item in listObj) { 
                Console.WriteLine(item);
            }

            listObj.Remove(10);
            Console.WriteLine("지운 후");
            foreach (int item in listObj)
            {
                Console.WriteLine(item);
            }

        }
    }
}
