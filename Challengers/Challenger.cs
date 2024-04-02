using System.Diagnostics;
using SolvingHackerRankChallengers.Challengers.Answers;

namespace SolvingHackerRankChallengers.Challengers;

public static class Challenger
{
    // This class will be responsible for calling the challenge methods
    public static void Start()
    {
        long MyNumber = 1;
        // 2147483648 

        var c = FlippingBits.Start(MyNumber);

        Console.WriteLine(c);

    }
}