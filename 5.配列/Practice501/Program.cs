namespace Practice501
{
    class Program
    {
        static void Main(string[] args)
        {
            // 乱数の生成回数をコンソールから受け取り
            int randNumGenerateCount = int.Parse(Console.ReadLine());
            int[] randamArray = new int[randNumGenerateCount];

            // Point: 今回は、0以上100未満という範囲が分かっているので、適切な初期値を設定可能。
            // Point: 範囲が分からない場合は先頭の要素を暫定の最大値・最小値として探索を行う（M-1グランプリや歌うま選手権）
            
            int max = 0;
            int min = 100;
            int sum = 0;

            // Point: ループの前、最中、後で何をすべきか？を整理する。

            // ループに入る前に出力
            Console.Write("生成された乱数：");

            // 乱数を生成し配列を作成
            // 最大値、最小値も一度に探索
            for (int i = 0; i < randNumGenerateCount; i++)
            {
                // 配列の要素を代入
                Random rand = new Random();
                randamArray[i] = rand.Next(1, 100);

                // C#での乱数生成は、1000ミリ秒置きに行わないと同一の値を出力してしまうため、実行を待つ処理を追加
                // ※繰り返し処理の中で何度も乱数を生成するような場合に用いる。
                System.Threading.Thread.Sleep(1000);

                // 最大値の探索
                if (max < randamArray[i])
                {
                    max = randamArray[i];
                }

                // 最小値の探索
                if (min > randamArray[i])
                {
                    min = randamArray[i];
                }

                // 合計の計算
                sum = sum + randamArray[i];

                // 配列の要素の出力
                Console.Write(randamArray[i]);

                // 最後の要素以外は,をつける
                if (i != randNumGenerateCount - 1)
                {
                    Console.Write(",");
                }
            }

            // ループ終了後に改行
            Console.WriteLine();

            // 平均値の計算
            double avg = (double)sum / randamArray.Length;

            // 最大、最小、平均を出力
            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値：" + min);
            Console.WriteLine("平均値：" + avg);
        }
    }
}
