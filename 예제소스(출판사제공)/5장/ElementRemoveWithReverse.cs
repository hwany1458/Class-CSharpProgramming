namespace ElementRemoveWithReverse
{
    // 코드 5-21: foreach 반복문으로 요소 제거
    internal class Program
    {
        class Student
        {
            public string name;
            public int grade;
        }

        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "연하진", grade = 2 });
            list.Add(new Student() { name = "윤아린", grade = 3 });
            list.Add(new Student() { name = "윤명월", grade = 4 });
            list.Add(new Student() { name = "구지연", grade = 1 });
            list.Add(new Student() { name = "김연화", grade = 2 });

            // 예외가 발생하므로 주석으로 처리했습니다.
            // foreach (var item in list)
            // {
            //     if (item.grade > 1)
            //     {
            //         list.Remove(item);
            //     }
            // }

            // 코드 5-22: for 반복문으로 요소 제거
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            // 코드 5-23: 역 for 반복문을 사용한 요소 제거
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}
