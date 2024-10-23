namespace Practice203
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("リンゴの合計金額：");
            int appleSumCost = int.Parse(Console.ReadLine());

            Console.Write("リンゴの個数：");
            int appleQty = int.Parse(Console.ReadLine());

            double avgCost = (double)appleSumCost / (double)appleQty;
            Console.WriteLine("平均単価：" + avgCost);
        }
    }
}