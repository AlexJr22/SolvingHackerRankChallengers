namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class MatchingStrings
{
    public static List<int> Start(List<string> strings, List<string> queries)
    {
        List<int> result = [];

        for (int queryIndex = 0; queryIndex < queries.Count; queryIndex++) 
        {
            int Count = 0;

            for (int StrIndex = 0;  StrIndex < strings.Count; StrIndex++)
                if (queries[queryIndex] == strings[StrIndex]) 
                    Count++;   

            result.Add(Count);
        }

        return result;
    }
}
