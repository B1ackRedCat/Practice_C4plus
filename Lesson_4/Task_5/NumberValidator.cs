using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_5
{
    internal class NumberValidator
    {
        public static string numberPattern = @"[a-z]{3}[1-9]{2}[a-z]{2}";
        internal static bool Validate(string? input)
        {
            var regex = new Regex(numberPattern);
            return regex.IsMatch(input);
        }
    }
}
