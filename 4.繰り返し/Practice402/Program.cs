namespace Practice402
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int i = 0;
            while (i <= inputNum)
            {
                Console.Write(i + " ");

                // Point: iの増加処理を忘れない
                i++;
            }


            // Point: ループが終了した後に改行
            Console.WriteLine();
            Console.Write("以上です。");
        }
    }
}