namespace Practice306
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("リンゴの個数：");
            int appleQty = int.Parse(Console.ReadLine());

            Console.Write("オレンジの個数：");
            int orangeQty = int.Parse(Console.ReadLine());

            if (appleQty == orangeQty)
            {
                Console.WriteLine("リンゴとオレンジの個数は同じ。");
            }
            // Point: 今回は、どちらの条件も満たす場合が存在するので、else ifではない。
            if (appleQty <= orangeQty)
            {
                Console.WriteLine("リンゴの個数はオレンジの個数以下");
            }
        }
    }
}