using System.Reflection;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10.07.
            // 배열 선언
            int[] intArr = { 10, 20, 30, 40 }; 
            // Check: 배열선언 오류가 어떤 메시지 나오는지 확인
            // 배열에서 읽어올 때, 변수=배열[인덱스] 
            int a = intArr[1];
            // 배열에 쓸 때, 배열[인덱스] = 값
            intArr[3] = 100;

            // for문
            //(1)초기식; (2)조건식; (3)증감식
            for (int i=0; i<4; i++)
            {
                Console.WriteLine(intArr[i]);
            }
            // 배열 인덱스 번호를 초과하면 어떤 메시지 나올까요?
            //intArr[4] = 1000;
            // 컴파일 오류는 안남
            // 실행중 오류(런타임오류) 발생: index out of range ..


            // while문
            int j = 0;
            while (j<4)
            {
                Console.WriteLine(intArr[j] + " [" + j + "]");
                j++;
            }

            // isDead, hp를 사용 (hp=100)
            // while문을 사용해서,
            // 맞으면 hp 감소, hp<0로 내려가면 캐릭터 다이, 게임종료
            
            bool isDead = false;
            int hp = 100;
            while (!isDead)
            {
                Console.Write("옆구리 맞음 ");
                hp = hp - 20;
                Console.WriteLine(hp);
                if (hp < 0)
                { 
                    isDead = true;
                    Console.WriteLine("유 다이...");
                }
            }
            int z = 5;
            while (z != 0) // ; -- 이렇게 쓰면, (조건식이 바뀌지 않아서, 여기서) 무한루프를 돔
            {
                Console.WriteLine(z);
                z--;
            }


        }
    }
}
