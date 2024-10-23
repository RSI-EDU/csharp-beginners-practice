namespace Practice413
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point: 大→小となるように、ループの度にカウンタをデクリメント
            for (int i = 10; i >= 7; i--)
            {
                Console.WriteLine("a = " + i);
            }
        }
    }
}