namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class Median
{
    public static int Start(List<int> arr)
    {
        arr.Sort();

        int n = arr.Count + 1;
        int n2 = n / 2;

        return arr[n2 - 1];
    }
}
