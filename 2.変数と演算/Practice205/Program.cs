namespace Practice205
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("名字は？：");
            string lastName = Console.ReadLine();

            Console.Write("名前は？：");
            string firstName = Console.ReadLine();

            Console.WriteLine("名字の長さは{0}です。", lastName.Length);
            Console.WriteLine("名前の長さは{0}です。", firstName.Length);

            // Point: 文字列は+で結合可能。
            string fullName = lastName + firstName;
            Console.WriteLine("合計の長さは{0}です。", fullName.Length);
        }
    }
}