namespace Enum
{
    enum OrderState { Ordered, Paymented, Prepared, Sended };

    internal class Program
    {
        static OrderState OrderCheck(int orderId)
        {
            return OrderState.Ordered;
        }

        static void Main(string[] args)
        {
            if (OrderCheck(12345) == OrderState.Ordered)
            {
                Console.WriteLine("주문 완료되었습니다.");
            }
        }
    }
}
