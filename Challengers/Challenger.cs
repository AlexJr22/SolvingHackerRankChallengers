using SolvingHackerRankChallengers.Challengers.Answers;

namespace SolvingHackerRankChallengers.Challengers;

public static class Challenger
{
    // This class will be responsible for calling the challenge methods
    public static void Start()
    {
        int n = 6;
        int k = 3;
        List<int> arr = [1, 3, 2, 6, 1, 2];

        Console.WriteLine(DivisibleSumPairs.Start(n, k, arr));
    }
}
