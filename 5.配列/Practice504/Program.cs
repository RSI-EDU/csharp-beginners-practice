namespace Practice504
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideLength = int.Parse(Console.ReadLine());

            // ひし形を作る

            // 上半分
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < 2 * sideLength - 1; j++)
                {
                    if (j + 1 == (sideLength - i) || j + 1 == (sideLength + i))
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine();
            }
            // 下半分
            for (int i = 0; i < sideLength - 1; i++)
            {
                for (int j = 0; j < 2 * sideLength - 1; j++)
                {
                    if (j == i + 1 || j == (2 * sideLength - 1) - (i + 2))
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}