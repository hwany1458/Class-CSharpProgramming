namespace ThirdProject
{
    //----- Class
    // 이동수단 클래스
    public class Transportation
    {
        // 속성(변수)
        public string plate;  // 번호판
        public string manufacturer;  // 제조사
        public string color;  // 색깔

        // 생성자
        public Transportation()
        {

        }

        public Transportation(string p, string m, string c)
        {
            this.plate = p;
            this.manufacturer = m;
            this.color = c;
        }

        // 기능, 행동 (메소드)
        // public -> protected : 자식클래스 접근 못함 (외부선언)
        public void MoveForward() { Console.WriteLine("앞으로 전진하다"); }
        public void MoveReverse() { Console.WriteLine("뒤로 후진하다"); }
        public void PutIntoGear() { Console.WriteLine("기어를 넣다"); }
        private void TestPrivate() { }
        public void TestMethod() { this.MoveForward();}

        public void Parking() { Console.WriteLine("이동수단을 주차합니다"); }
    }

    public class Car : Transportation
    {
        public string carType;

        // 생성자
        public Car() { }
        public Car(string p, string m, string c)
        {
            this.plate = p;
            this.manufacturer = m;
            this.color = c;
        }
        public void TurnOnNavi() { Console.WriteLine("네비를 켜다"); }

        public void Parking() { Console.WriteLine("자동차을 주차합니다"); }
        public void Parking(int me)
        {
            if (me == 1) { this.Parking(); }
            else { base.Parking(); }
        }

    }

        public class Bike : Transportation
        {
            public void ScanQRCode() { Console.WriteLine("QR코드를 찍다"); }
        }




        internal class Program
        {

            //-----------------------
            static void Main(string[] args)
            {
                // 11.18
                // 자동차 객체를 생성
                // 클래스 객체명 = new 생성자()
                Car car = new Car();

                // 부모클래스에서 상속받아 사용하는 속성
                car.manufacturer = "기아자동차";
                car.plate = "224나6396";

                // 자기자신이 가지고 있는 속성
                car.carType = "카니발";
                Console.WriteLine(car.manufacturer + " " + car.carType);

                // 상속받은 메소드
                car.MoveForward();
            //car.Parking();
            car.Parking(2);
           

                // 자기자신이 가지고 있는 메소em
                car.TurnOnNavi();

                Car car1 = new Car("22오8817", "현대자동차", "제네시스");
                Console.WriteLine(car1.manufacturer);
            }
        }
}
