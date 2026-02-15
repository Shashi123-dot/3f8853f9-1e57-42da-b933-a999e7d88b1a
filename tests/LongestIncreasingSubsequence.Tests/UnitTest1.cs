using Xunit;
using LongestIncreasingSubsequence;

namespace LongestIncreasingSubsequence.Tests
{
    public class LisSolverTests
    {
        private readonly LisSolver _solver = new LisSolver();

        [Fact]
        public void Should_Return_Longest_Increasing_Subsequence()
        {
            string input = "6 1 5 9 2";
            string expected = "1 5 9";

            var result = _solver.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_Return_Single_Element_When_All_Decreasing()
        {
            string input = "9 8 7 6";
            string expected = "9";

            var result = _solver.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_Return_Earliest_Sequence_When_Multiple_Exist()
        {
            string input = "1 3 2 4";
            string expected = "1 3 4";

            var result = _solver.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_Handle_Single_Number()
        {
            string input = "5";
            string expected = "5";

            var result = _solver.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_Return_Empty_For_Empty_Input()
        {
            string input = "";
            string expected = "";

            var result = _solver.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }
    }
}
