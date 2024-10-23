namespace Practice307
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum % 2 == 0)
            {
                Console.WriteLine("奇数ではありません。");
            }
            else
            {
                Console.WriteLine("偶数ではありません。");
            }
        }
    }
}