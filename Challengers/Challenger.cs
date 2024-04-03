using System.Diagnostics;
using SolvingHackerRankChallengers.Challengers.Answers;

namespace SolvingHackerRankChallengers.Challengers;

public static class Challenger
{
    // This class will be responsible for calling the challenge methods
    public static void Start()
    {
        List<List<int>> arr = [
            [11,2,4],
            [4,5,6],
            [10,8,-12],
        ];

        //List<List<int>> arr = [
        //    [2],
        //    [6,8],
        //    [-6,9],
        //];


        int result = DiagonalDifference.Start(arr);

        Console.WriteLine(result);
    }
}