using System.Diagnostics;
using SolvingHackerRankChallengers.Challengers.Answers;

namespace SolvingHackerRankChallengers.Challengers;

public static class Challenger
{
    // This class will be responsible for calling the challenge methods
    public static void Start()
    {
        List<int> arr = [0, 1, 2, 4, 6, 5, 3];
        var n = Median.Start(arr);

        Console.WriteLine(n);
    }
}
