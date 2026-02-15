using System;
using System.Collections.Generic;
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

            int n = numbers.Length;

            if (n == 0)
                return string.Empty;

            int[] length = new int[n];
            int[] previous = new int[n];

            Array.Fill(length, 1);
            Array.Fill(previous, -1);

            int maxLength = 1;
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] &&
                        length[j] + 1 > length[i])
                    {
                        length[i] = length[j] + 1;
                        previous[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    maxIndex = i;
                }
            }

            var sequence = new List<int>();

            while (maxIndex != -1)
            {
                sequence.Add(numbers[maxIndex]);
                maxIndex = previous[maxIndex];
            }

            sequence.Reverse();

            return string.Join(" ", sequence);
        }
    }
}
