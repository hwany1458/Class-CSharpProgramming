namespace ThreeModifiers
{
    internal class Program
    {
        class Animal
        {
            private void Private() { }
            protected void Protected() { }
            public void Public() { }

            public void TestA()
            {
                Private();
                Protected();
                Public();
            }
        }

        class Dog : Animal
        {
            public void TestB()
            {
                Protected();
                Public();
            }
        }
                
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Public();
        }
    }
}
