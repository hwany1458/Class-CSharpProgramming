namespace Interfaces
{
    internal class Program
    {
        // 코드 9-14: 다중 상속
        class Parent { }

        class Child : Parent, IDisposable, IComparable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            // 코드 9-15: 다중 상속과 다형성
            Child child = new Child();
            Parent childAsParent = new Child();
            IDisposable childAsDisposable = new Child();
            IComparable childAsComparable = new Child();
        }
    }
}
