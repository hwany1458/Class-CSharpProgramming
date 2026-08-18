namespace CustomException
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomException("사용자 정의 예외");
            }
            catch (CustomException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
