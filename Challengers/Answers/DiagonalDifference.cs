namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class DiagonalDifference
{
    public static int Start(List<List<int>> arr)
    {
        int sum,
            firstDiagonal = 0,
            secondDiagonal = 0;

        for (int rowAndCol = 0; rowAndCol < arr.Count; rowAndCol++)
        {
            firstDiagonal += arr[rowAndCol][rowAndCol];

            arr[rowAndCol].Reverse();

            secondDiagonal += arr[rowAndCol][rowAndCol];
        }

        sum = Math.Abs(firstDiagonal - secondDiagonal);

        return sum;
    }
}


//int sum = 0, firstDiagonal = 0, secondDiagonal = 0;

//int lenghtMatrix = arr[0][0];

//        for (int row = 1; row <= lenghtMatrix; row++)
//        {
//            int col = row - 1;

//firstDiagonal += arr[row][col];
//        }

//        for (int row = 1; row <= lenghtMatrix; row++)
//{
//    arr[row].Reverse();
//}

//for (int row = 1; row <= lenghtMatrix; row++)
//{
//    int col = row - 1;

//    secondDiagonal += arr[row][col];
//}

//sum = Math.Abs(firstDiagonal - secondDiagonal);
