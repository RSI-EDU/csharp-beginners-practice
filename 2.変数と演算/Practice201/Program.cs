namespace Practice201
{
    class Program
    {
        static void Main(string[] args)
        {
            // 解答は、xとyへの代入の値を毎回手で変えてよい。
            int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());

            int addResult = x + y;
            int subResult = x - y;
            int multRssult = x * y;

            // Point: 整数同士であっても割り算は小数になる可能性がある点に注意。
            // 原則、型は演算前に合わせる。
            double divResult = (double)x / (double)y;
            double remResult = x % y;

            // 分かりやすいようにコンソール上に出力している。
            // 解答には含めなくてよい。
            Console.WriteLine("和：" + addResult);
            Console.WriteLine("差：" + subResult);
            Console.WriteLine("積：" + multRssult);
            Console.WriteLine("商：" + divResult);
            Console.WriteLine("剰余：" + remResult);
        }
    }
}