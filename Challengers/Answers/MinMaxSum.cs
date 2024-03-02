namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class MinMaxSum
{
    public static void Start(List<int> arr)
    {
        arr.Sort();

        int Length = arr.Count;
        long MinSum = 0;
        long MaxSum = 0;

        //MinSum
        for (int i = 0; i < (Length - 1); i++)
            MinSum += arr[i];

        // MaxSum
        for (int i = 1; i < Length; i++)
            MaxSum += arr[i];

        Console.Write($"{MinSum} {MaxSum}");
    }
}
