namespace SolvingHackerRankChallengers.Challengers.Answers;

public static class FlippingBits
{
    public static long Start(long number)
    {
        var list = ConvertToBinary(number);

        var Number = ConvertToDecimal(list);

        return Number;
    }

    public static List<int> ConvertToBinary(long numberDecimal)
    {
        // Convertendo para binario de 32 bits
        List<int> Binarys = [];
        List<int> ListOfBits = [];

        while (numberDecimal > 0)
        {
            int rest = (int)numberDecimal % 2;

            Binarys.Add(rest);

            numberDecimal /= 2;
        }

        Binarys.Reverse();

        int lenghtBinarys = Binarys.Count;
        int IndexListOfBits = 32 - lenghtBinarys;

        //foreach (var a in Binarys)
        //    ListOfBits[IndexListOfBits] = a;

        for (int index = 0; index < 33; index++)
        {
            if (index >= IndexListOfBits)
            {
                for (int index2 = 0; index2 < lenghtBinarys; index2++)
                    ListOfBits.Add(Binarys[index2]);

                break;
            }
            else
                ListOfBits.Add(0);
        }

        // invertendo o sinal do binario

        int[] NewListOfBits = new int[32];

        for (int index = 0; index < 31; index++)
        {
            if (ListOfBits[index] == 0)
                NewListOfBits[index] = 1;

            if (ListOfBits[i] == 1)
                NewListOfBits[index] = 0;
        }

        List<int> ListInts = NewListOfBits.ToList();

        ListInts.Reverse();

        return ListInts;
    }

    public static long ConvertToDecimal(List<int> bits)
    {
        long Number = 0;
        List<long> results = [];

        for (int index = 0; index < bits.Count; index++)
        {
            var powResult = (long)Math.Pow(2, i);

            results.Add(bits[index] * powResult);
        }

        foreach (var result in results)
            Number += result;

        return Number; // 2147483648
    }

    // metodo criado pelo J para ajudar na solocao
    public static void teste()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        string binario = "";

        while (x > 0)
        {
            int y = x % 2;
            binario = y.ToString() + binario;
            x /= 2;
        }

        Console.WriteLine($"O valor do binário é: {binario}");
    }
}
