using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingHackerRankChallengers.Challengers.Answers
{
    public static class PlusMinus
    {
        public static void Start(List<int> arr)
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
    }
}
