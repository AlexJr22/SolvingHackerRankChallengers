using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingHackerRankChallengers.Challengers.Answers
{
    public static class TimeConversion
    {
        public static string Start(string s)
        {
            DateTime Hour;

            if (DateTime.TryParse(s, out Hour))
                return Hour.ToString("HH:mm:ss");
            else
                return "incompatible format";
        }

    }
}
