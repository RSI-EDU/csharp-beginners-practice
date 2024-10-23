namespace Practice415
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNum; i++)
            {
                // Point: 「15で割り切れる数」 = 「3で割り切れるし、5で割り切れる」を基本方針
                string outputString = "";
                if (i % 3 == 0)
                {
                    outputString += "Fizz";
                }
                if (i % 5 == 0)
                {
                    outputString += "Buzz";
                }

                if (outputString == "")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(outputString);
                }
            }
        }
    }
}