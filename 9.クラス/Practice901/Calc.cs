
namespace Practice901
{
    internal class Calc
    {
        /// <summary>
        /// int型配列の最大値取得
        /// </summary>
        /// <param name="CalculationTargetArray"></param>
        /// <returns></returns>
        public int Max(int[] CalculationTargetArray)
        {
            // 暫定一位（最大）
            int max = CalculationTargetArray[0];
            foreach(int target in CalculationTargetArray)
            {
                if(max < target)
                {
                    max = target;
                }
            }
            return max;
        }
        /// <summary>
        /// int型配列の最小値取得
        /// </summary>
        /// <param name="CalculationTargetArray"></param>
        /// <returns></returns>
        public int Min(int[] CalculationTargetArray)
        {
            // 暫定一位（最小）
            int min = CalculationTargetArray[0];
            foreach (int target in CalculationTargetArray)
            {
                if (min > target)
                {
                    min = target;
                }
            }
            return min;
        }
        /// <summary>
        /// 配列の要素で同じ数が3つ続いていた場合コンソール上に”BINGO!”と出力
        /// </summary>
        /// <param name="SearchTargetArray"></param>
        public void Bingo(int[] SearchTargetArray)
        {
            int bingoCount = 1;
            for(int i = 0; i < SearchTargetArray.Length; i++)
            {
                // 先頭は調査しない。先頭以外の場合は連続しているか調査
                if(i!=0 && SearchTargetArray[i-1] == SearchTargetArray[i])
                {
                    bingoCount++;
                }
                else
                {
                    bingoCount = 1;
                }

                // 3回連続で同じ数が続いていたらBINGOと出力してループ終了
                if (bingoCount >= 3)
                {
                    Console.WriteLine("BINGO!");
                    break;
                }
            }


        }
        /// <summary>
        /// 以下の場合戻り値false、それ以外はtrue<br></br>
        /// ・引数（配列）の先頭が 0<br></br>
        /// ・引数（配列）の要素に負の数が含まれている
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool CanCalc(int[] a)
        {
            bool canCalc = true;

            // 配列の先頭が0だったら戻り値false
            if (a[0] == 0)
            {
                return canCalc = false;
            }

            // 要素に一つでも負の数があれば戻り値false
            foreach(int element in a)
            {
                if(element < 0)
                {
                    return canCalc = false;
                }
            }

            // いずれでもなければ戻り値true
            return canCalc;

        }

    }
}
