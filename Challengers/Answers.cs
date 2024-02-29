﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveHackerRankChallengers.Challengers
{
    public static class Answers
    {
        public static void PlusMinus(List<int> arr)
        {
            decimal Zeros = 0;
            decimal Positives = 0;
            decimal Negatives = 0;

            decimal Length = arr.Count;

            for (int index = 0; index < Length; index++)
            {
                if (arr[index] > 0)
                    Positives++;
                else if (arr[index] < 0)
                    Negatives++;
                else
                    Zeros++;
            }

            Console.WriteLine($"{Positives / Length:F6}");
            Console.WriteLine($"{Negatives / Length:F6}");
            Console.WriteLine($"{Zeros / Length:F6}");
        }

        public static void MinMaxSum(List<int> arr)
        {
            arr.Sort();

            int Length = arr.Count;
            long MinSum = 0;
            long MaxSum = 0;

            //MinSum
            for (int i = 0; i < (Length - 1); i++)
                MinSum += arr[i];

            // MazSum
            for (int i = 1; i < Length; i++)
                MaxSum += arr[i];

            Console.Write($"{MinSum} {MaxSum}");
        }
    }
}
