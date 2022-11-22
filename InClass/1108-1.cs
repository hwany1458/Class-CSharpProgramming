using System;

namespace ConsoleApp1
{
    // 학습 과정에서 주석처리한 부분을 주석제거하여 업로드함
    // 따라서, 코드의 컴파일 오류 또는 실행오류가 날수도 있음
    // 아래 코드는 (단순하게) 개념을 이해하기 위한 내용임
    class Box
    {
        private int width;
        public int Width { get; set; }
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("width에 양수를 입력"); }
            }
        }

        private int height;
        public int Height { get; set; }
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { Console.WriteLine("height에 양수를 입력"); }
            }
        }


        // getter
        public int GetWidth() { return width; }
        public int GetHeight() { return height; }

        // setter
        public void SetWidth(int w)
        {
            if (w > 0) { this.width = w; }
            else { Console.WriteLine("오류] width에 양수를 입력하세요");  }
        }
        public void SetHeight(int h)
        {
            if (h>0) { this.height = h; }
            else { Console.WriteLine("오류] height에 양수를 입력하세요"); }
        }

        // 생성자
        public Box(int w, int h)
        {
            if (w>0 && h>0) { 
                this.width = w;
                this.height = h;
            } else {
                Console.WriteLine("오류] 가로, 세로에 0값이 들어갔습니다...");
            }
        }
        public Box(int w, int h)
        {
                this.width = w;
                this.height = h;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box obj = new Box(10, 10);
            
            // 캡슐화 예시
            Box obj1 = new Box(-10, -10);

            // private으로 선언되어, 접근이 불가
            //Console.WriteLine(obj.width);
            // getter를 통해 속성정보를 가져옴
            //Console.WriteLine(obj.GetHeight() + "-" + obj.GetWidth());
            obj.Width = 20;
            Console.WriteLine(obj.Height + "-" + obj.Width);

            Console.WriteLine($"박스 면적은 {obj.Area()}");
        }
    }
}
