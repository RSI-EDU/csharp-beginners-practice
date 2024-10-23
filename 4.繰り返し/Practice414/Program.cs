namespace Practice414
{
    class Program
    {
        static void Main(string[] args)
        {
            int sub = 10;
            // Point: 大→小となるように、ループの度にカウンタをデクリメント
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("a = " + sub);
                sub = sub - 3;
            }
        }
    }
}