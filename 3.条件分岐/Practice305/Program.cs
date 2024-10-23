namespace Practice305
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            // Point: 範囲を指定する場合小さいほうから並べると読みやすい
            if (30 < inputNum && inputNum <= 70)
            {
                Console.WriteLine("30より大きく70以下です。");
            }
        }
    }
}