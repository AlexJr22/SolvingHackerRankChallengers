namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class Lonelyinteger
{
    public static int Start(List<int> a)
    {
        for (int index = 0; index < a.Count; index++)
        {
            var CountInt = 1;

            for (int SecudIndex = 0; SecudIndex < a.Count; SecudIndex++)
            {
                if (index != SecudIndex)
                    if (a[index] == a[SecudIndex]) CountInt++;
            }

            if (CountInt == 1)
                return a[index];
        }

        return 0;
    }
}

