using System;

namespace ConsoleApp2
{
    class TV
    {
        // TV 속성 (브랜드, 모델, 화면크기, 해상도, 디스플레이유형 ...)
        string brand;  // 브랜드
        string model;   // 모델명
        int displaySize; // 화면크기
        string resolution;  // 해상도
        string displayType; // 디스플레이유형

        // TV 기능 (스마트기능, 음성제어, 앱지원, 화면공유 ...)
        // 스마트기능 (인터넷연결하기, 스트리밍서비스받기 ..)
        bool InternetConnect()  // 인터넷연결하기 기능
        {
            bool onOff;
            return onOff;
        }
        void StreamingService() { } // 스트리밍서비스받기 기능
        void VoiceRecognition() { }  // 음성인식하기 기능
    }

    class Program  // Program 이라는 이름으로 클래스를 정의
    {
        // 속성



        // 기능

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 변수 선언, 값할당
            int a = 10;
            // a라는 이름으로 정수형 변수를 선언, 
            // 값(10)을 변수 a에 할당

            // 클래스에서 객체를 생성
            // 클래스명 객체변수이름 = new 클래스명();
            TV naYeonTV = new TV();
            naYeonTV.brand = "삼성";
            naYeonTV.displaySize = 43;
            naYeonTV.InternetConnect();
        }
    }
}
