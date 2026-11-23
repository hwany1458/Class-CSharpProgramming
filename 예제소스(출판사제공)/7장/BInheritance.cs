namespace BInheritance
{
    internal class Program
    {
        // 코드 7-4: Animal 클래스
        class Animal
        {
            public int Age { get; set; }

            public Animal() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        }

        // 코드 7-5: Animal 클래스의 상속을 받는 Dog와 Cat 클래스
        class Dog : Animal
        {
            public string Color { get; set; }
            
            public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
        }

        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
