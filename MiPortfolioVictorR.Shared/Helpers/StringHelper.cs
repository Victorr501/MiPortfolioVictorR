using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPortfolioVictorR.Shared.Helpers
{
    public static class StringHelper
    {
        public static string Truncate(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text) || text.Length <= maxLength) return text;

            return text[..maxLength].TrimEnd() + "...";
        }
    }
}
