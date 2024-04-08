namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class CountingSort
{
    public static List<int> Start(List<int> arr)
    {
        int[] nums = new int[100];

        foreach (int i in arr)
            nums[i] += 1;

        return [ ..nums ];
    }
}
