namespace Practice412
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point: 大→小となるように、ループの度にカウンタをデクリメント
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine("a = " + i);
            }
        }
    }
}