namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class GradingStudents
{
    public static List<int> Start(List<int> grades)
    {
        for (int index = 0; index < grades.Count; index++)
        {
            if (grades[index] >= 38)
            {
                if (grades[index] % 5 == 3)
                    grades[index] += 2;

                if (grades[index] % 5 == 4)
                    grades[index] += 1;
            }
        }

        return grades;
    }
}

