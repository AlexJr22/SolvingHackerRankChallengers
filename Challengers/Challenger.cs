using SolvingHackerRankChallengers.Challengers.Answers;

namespace SolvingHackerRankChallengers.Challengers;

public static class Challenger
{
    // This class will be responsible for calling the challenge methods
    public static void Start()
    {
        List<int> grades = [4, 73, 67, 38, 33];

        var g = GradingStudents.Start(grades);

        foreach (var grade in g)
        {
            Console.WriteLine(grade);
        }
    }
}
