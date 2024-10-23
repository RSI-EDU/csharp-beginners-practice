namespace Practice304
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            // Point: 不等号の向きを揃えておくと読みやすい
            if (inputNum < 20 || 80 <= inputNum)
            {
                Console.WriteLine("20未満か80以上です。");
            }
        }
    }
}