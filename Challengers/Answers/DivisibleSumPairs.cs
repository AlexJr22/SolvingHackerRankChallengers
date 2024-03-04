namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class DivisibleSumPairs
{
    public static int Start(int n, int k, List<int> arr)
    {
        if (n == arr.Count)
        {
            int pairs = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                int currentNumber = arr[i];

                for (int j = 0; j < arr.Count; j++)
                {
                    if (j != i)
                    {
                        int currentSum = currentNumber + arr[j];

                        if (currentSum % k == 0)
                            pairs++;
                    }
                }
            }

            return pairs / 2;
        }

        return 0;
    }
}
