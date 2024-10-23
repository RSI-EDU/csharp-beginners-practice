namespace Practice308
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            // Point: 「範囲外」のようなケースは頭の中から排除したいので先に書くのも良い
            if (inputNum < 0 || 100 < inputNum)
            {
                Console.WriteLine("範囲外です。");

            }
            // Point: 範囲外を先に処理したので、安心して範囲内の事に注力できる
            else
            {
                if (20 < inputNum && inputNum <= 80)
                {
                    Console.WriteLine("20より大きく80以下です。");
                }
                // Point: 「20より大きく80以下」 = 「20以下または80より大きい」
                else
                {
                    Console.WriteLine("20以下または80より大きいです。");
                }
            }
        }
    }
}