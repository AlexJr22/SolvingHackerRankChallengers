using System.Diagnostics;
using SolvingHackerRankChallengers.Challengers.Answers;

namespace SolvingHackerRankChallengers.Challengers;

public static class Challenger
{
    // This class will be responsible for calling the challenge methods
    public static void Start()
    {
        var s = "We promptly judged antique ivory buckles for the next prize";
        Console.WriteLine(Pangram.Start(s));
    }
}
