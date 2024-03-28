using SolvingHackerRankChallengers.Challengers.Answers;
using System.Diagnostics;

namespace SolvingHackerRankChallengers.Challengers;

public static class Challenger
{
    // This class will be responsible for calling the challenge methods
    public static void Start()
    {
        List<string> str = ["ab", "ab", "abc"];
        List<string> query = ["ab", "ac", "abc"];

        // 2, 0, 1

        var Results = MatchingStrings.Start(str, query);

        foreach (int n in Results)
            Console.WriteLine(n);
    }
}
