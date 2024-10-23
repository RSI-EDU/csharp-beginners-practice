namespace Practice302
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            // Point: 論理演算を用いる
            if (inputNum == 3 || inputNum == 4)
            {
                Console.WriteLine("3または4です。");
            }
        }
    }
}