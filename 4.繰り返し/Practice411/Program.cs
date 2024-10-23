namespace Practice411
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("a = " + sum);

                // Point: 最初は1が出力されるので、出力後に加算
                sum = sum + 3;
            }
        }
    }
}