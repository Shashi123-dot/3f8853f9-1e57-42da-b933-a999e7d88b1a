using System;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by single whitespace:");
            string input = Console.ReadLine();

            var solver = new LisSolver();
            string result = solver.GetLongestIncreasingSubsequence(input);

            Console.WriteLine("Result:");
            Console.WriteLine(result);
        }
    }
}
