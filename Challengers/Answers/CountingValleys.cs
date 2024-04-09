namespace SolvingHackerRankChallengers.Challengers.Answers;

public class CountingValleys
{
    public static int Start(int steps, string path)
    {
        bool IsValley = false;
        int valleysTraversed = 0;
        int level = 0;

        char[] pathValues = path.ToUpper().ToCharArray();

        for (int i = 0; i < steps; i++)
        {
            if (pathValues[i] == 'U')
                level++;
            else
                level--;

            if (level < 0 && !IsValley)
                IsValley = true;

            if (level == 0 && IsValley)
            {
                IsValley = false;
                valleysTraversed++;
            }
        }

        return valleysTraversed;
    }
}
