namespace Practice502
{
    class Program
    {
        static void Main(string[] args)
        {
            // 乱数の生成回数をコンソールから受け取り
            int randNumGenerateCount = int.Parse(Console.ReadLine());
            int[] randamArray = new int[randNumGenerateCount];

            // 偶数の個数
            int evenCount = 0;

            // 奇数の個数
            int oddCount = 0;

            // ループに入る前に出力
            Console.Write("生成された乱数：");

            // 乱数を生成し配列を作成
            for (int i = 0; i < randNumGenerateCount; i++)
            {
                Random rand = new Random();
                randamArray[i] = rand.Next(1, 100);

                if (randamArray[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                // コンソールに出力
                if (i == 0)
                {
                    Console.Write(randamArray[i]);
                }
                else
                {
                    Console.Write("," + randamArray[i]);
                }
            }

            // ループ終了後に改行
            Console.WriteLine();

            // 奇数の個数出力
            Console.WriteLine("奇数の個数：" + oddCount);

            // 偶数の個数出力
            Console.WriteLine("偶数の個数：" + evenCount);

            // 奇数の出力
            Console.Write("奇数である値：");
            oddCount = 0;
            for (int i = 0; i < randamArray.Length; i++)
            {
                if (randamArray[i] % 2 != 0)
                {
                    if (oddCount == 0)
                    {
                        Console.Write(randamArray[i]);
                    }
                    else
                    {
                        Console.Write("," + randamArray[i]);
                    }
                    oddCount++;
                }
            }
            // ループ終了後に改行
            Console.WriteLine();

            // 偶数の出力
            Console.Write("偶数である値：");
            evenCount = 0;
            for (int i = 0; i < randamArray.Length; i++)
            {
                if (randamArray[i] % 2 == 0)
                {
                    if (evenCount == 0)
                    {
                        Console.Write(randamArray[i]);
                    }
                    else
                    {
                        Console.Write("," + randamArray[i]);
                    }
                    evenCount++;
                }
            }
        }
    }
}