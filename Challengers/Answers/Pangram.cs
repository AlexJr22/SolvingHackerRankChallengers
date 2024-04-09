namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class Pangram
{
    public static string Start(string s)
    {
        char[] alfabeto = 
            ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
        char[] Contains = new char[alfabeto.Length];

        for (int i = 0; i < alfabeto.Length; i++)
            if (s.ToLower().Contains(alfabeto[i]))
                Contains[i] = alfabeto[i];

        if (alfabeto.SequenceEqual(Contains))
            return "pangram";

        return "not pangram";
    }
}

