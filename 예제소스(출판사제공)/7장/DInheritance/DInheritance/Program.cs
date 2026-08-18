namespace DInheritance
{
    class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }

    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
    }

    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 코드 7-14: is 키워드
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Cat(), new Cat()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                // 코드 7-15: 일반적인 자료형 변환
                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }

                // 코드 7-16: as 키워드를 사용한 자료형 변환
                // if (item is Dog) { (item as Do/*g).Bark(); }
                // if (item is Dog) { (item as Ca*/t).Meow(); }

                // 코드 7-17: as 키워드를 사용하는 경우의 일반적인 형태
                // var dog = item as Dog;
                // if (dog != null) { dog.Bark(); }
                
                // var cat = item as Cat;
                // if (cat != null) { cat.Meow(); }
            }
        }
    }
}
