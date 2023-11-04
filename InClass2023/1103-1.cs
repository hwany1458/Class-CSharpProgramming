using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main2(string[] args)
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

           // 숙제
            obj1.Add(50);
            obj1.Remove(50);

            int cnt = obj1.Count;
            // 들어간 있는 놈(int)들을 출력
            for (int j=0; j<obj1.Count; j++) {
                Console.WriteLine("Count:" + (j+1) + "/" + cnt + ", Item:" + obj1[j]);
            }
            /*
             * foreach(int item in obj1)
            { 
                Console.WriteLine(item);
            }
            */

            // 돌려보기 ..
            // 동일한 데이터(값50)가 2개 들어있을때
            //(1) 앞의 데이터가 삭제
            //(2) 뒤의 데이터가 삭제
            //(3) 둘다 삭제
            //(4) 둘다 안 삭제 (어떤 것을 삭제해야 하는지 모호하기 때문에)

            int foundInt = obj1.Find(x => x == 1000);
            Console.WriteLine(foundInt);
        }
    }
}
