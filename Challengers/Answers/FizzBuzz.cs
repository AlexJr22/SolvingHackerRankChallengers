using System.Security.AccessControl;

namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class FizzBuzz
{
    public static void Start(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else
                    Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                if (i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            else
                Console.WriteLine(i);
        }
    }
}
