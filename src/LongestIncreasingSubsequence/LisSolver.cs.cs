using System;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    public class LisSolver
    {
        public string GetLongestIncreasingSubsequence(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var numbers = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 0)
                return string.Empty;

            // Temporary simple logic:
            // Return first number (we will improve later)
            return numbers[0].ToString();
        }
    }
}
