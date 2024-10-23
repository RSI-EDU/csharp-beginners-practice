namespace Practice407
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point: 2の0乗は1なので、初期値0
            int pow = 1;
            for (int i = 1; i <= 5; i++)
            {
                pow = pow * 2;
                Console.WriteLine("a = " + pow);
            }
        }
    }
}