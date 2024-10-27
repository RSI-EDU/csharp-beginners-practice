using Practice901;

namespace Plactice901
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calcTargetArray = { 7,7,8,8,9,9,9};

            Calc calc = new Calc();

            // 計算対象でなければ処理終了
            if (!calc.CanCalc(calcTargetArray))
            {
                Console.WriteLine("計算対象ではありません。");
            }
            else
            {
                Console.WriteLine("計算対象です。次の処理に進みます。");

                // 最大値取得
                int max = calc.Max(calcTargetArray);
                Console.WriteLine(max);

                // 最小値取得
                int min = calc.Min(calcTargetArray);
                Console.WriteLine(min);

                // BINGOゲーム
                calc.Bingo(calcTargetArray);
            }


        }
    }
}