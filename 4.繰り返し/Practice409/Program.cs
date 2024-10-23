namespace Practice409
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point: 3の0乗は1なので、初期値0
            int pow = 1;
            for (int i = 1; i <= 4; i++)
            {
                pow = pow * 3;
                Console.WriteLine("a = " + pow);
            }
        }
    }
}