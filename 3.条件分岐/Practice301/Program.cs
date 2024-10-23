namespace Practice301
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            if (inputNum > 5)
            {
                Console.WriteLine("{0}は5より大きいです。", inputNum);
            }
            else if (inputNum < 5)
            {
                Console.WriteLine("{0}は5より小さいです。", inputNum);
            }
            else
            {
                Console.WriteLine(inputNum);
            }
        }
    }
}