using SolvingHackerRankChallengers.Challengers.Answers;

namespace SolvingHackerRankChallengers.Challengers;

public static class Challenger
{
    // This class will be responsible for calling the challenge methods
    public static void Start()
    {
        List<int> n = [1,1,2,2,3,3,3,4,5,5,6,6];

        var a = Lonelyinteger.Start(n);

        Console.WriteLine(a);
    }
}
