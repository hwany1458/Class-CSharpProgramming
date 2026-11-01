namespace ModelClassWithList
{
    internal class Program
    {
        // 코드 5-18: 모델 클래스
        class Student
        {
            public string name;
            public int grade;
        }

        // 코드 5-19: 모델 클래스와 List 클래스
        static void Main(string[] args)
        {
            List<Student> list1 = new List<Student>();
            list1.Add(new Student() { name = "윤인성", grade = 1 });
            list1.Add(new Student() { name = "연하진", grade = 2 });
            list1.Add(new Student() { name = "윤아린", grade = 3 });
            list1.Add(new Student() { name = "윤명월", grade = 4 });
            list1.Add(new Student() { name = "구지연", grade = 1 });
            list1.Add(new Student() { name = "김연화", grade = 2 });

            foreach (var item in list1)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }

            // 코드 5-20: 리스트와 모델 클래스 동시 초기화
            List<Student> list2 = new List<Student>()
            {
                new Student() { name = "윤인성", grade = 1 },
                new Student() { name = "연하진", grade = 2 },
                new Student() { name = "윤아린", grade = 3 },
                new Student() { name = "윤명월", grade = 4 },
                new Student() { name = "구지연", grade = 1 },
                new Student() { name = "김연화", grade = 2 }
            };
        }
    }
}
