namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class BreakingRecords
{
    public static List<int> Start(List<int> scores)
    {
        int CountMinScore = 0;
        int CountMaxScore = 0;
        int MaxScore = scores[0];
        int MinScore = scores[0];

        foreach (int i in scores)
        {
            if (i > MaxScore)
            {
                CountMaxScore += 1;
                MaxScore = i;
            }

            if (i < MinScore)
            {
                CountMinScore += 1;
                MinScore = i;
            }
        }

        List<int> breakingRecords = [CountMinScore, CountMaxScore];
        return breakingRecords;
    }
}
