namespace Practice503
{
    class Program
    {
        static void Main(string[] args)
        {
            // 乱数の生成回数をコンソールから受け取り
            int randNumGenerateCount = int.Parse(Console.ReadLine());
            int[] randamArray = new int[randNumGenerateCount];

            // ループに入る前に出力
            Console.Write("生成された乱数：");

            // 乱数を生成しつつ配列を作成
            for (int i = 0; i < randNumGenerateCount; i++)
            {
                Random rand = new Random();
                int temp = rand.Next(1, 20);

                // 配列を探索して、重複していなければ代入
                bool isDuplication = false;
                foreach (int element in randamArray)
                {
                    // 重複する値がいれば重複フラグをtrueにする
                    if (temp == element)
                    {
                        isDuplication = true;
                    }
                }

                // 重複探索のループ終了時に重複を1件でも発見していれば、値の代入は行わず次の乱数に移る
                if (isDuplication)
                {
                    // continueを使うと、次のループにスキップ可能。
                    continue;
                }

                // Point: 重複無しの場合のみこのコードにたどり着く
                randamArray[i] = temp;
                Console.Write(randamArray[i] + " ");


            }
        }
    }
}