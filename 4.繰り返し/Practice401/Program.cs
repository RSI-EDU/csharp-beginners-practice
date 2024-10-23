namespace Practice401
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            // Point: ループの条件式は <=　となる。
            for (int i = 0; i <= inputNum; i++)
            {
                Console.Write(i + " ");
            }
            // Point: ループが終了した後に改行
            Console.WriteLine();
            Console.Write("以上です。");
        }
    }
}