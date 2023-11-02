using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main(string[] args)
        {
            // 정수형 배열
            int[] intArray = { 1,2,3,4,5 };
            intArray[2] = 100;

            // 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            //Random obj = new Random();
            List<int> obj1 = new List<int>();
            List<string> obj2 = new List<string>();

            obj1.Add(1);
            obj1.Add(2);

            for (int i=1; i<=10; i++)
            {
                obj1.Add(i*10);
            }

            obj1.Remove(10);

            // 들어간 있는 놈(int)들을 출력
            /*
            for (int j=0; j<obj1.Count; j++) {
                Console.WriteLine(obj1[j]);
            }
            */

            // 숙제
            // Add(50)
            // Remove(50)

            foreach(int item in obj1)
            {
                Console.WriteLine(item);
            }

            // 돌려보기 ..
        }
    }
}
