using AdventOfCode._2022.Day2;
using AdventOfCode.Helpers;
using Shouldly;
using Xunit;

namespace AdventOfCode.Tests_2022
{
    public class Day2SolutionTests
    {

        [Fact]
        public void Solution1_CalculateWinningScore_Returns_15_FromExampleData()
        {
            // Arrange
            var input = @"A Y
            B X
            C Z";

            var expected = 15;

            // Act
            var result = Day2Solution.CalculateScore(input);
            
            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Solution1_CalculateWinningScore_Returns_14531_FromInputFileData()
        {
            // Arrange
            var input = ImportHelpers.ReadFile("day2.txt");

            var expected = 14531;

            // Act
            var result = Day2Solution.CalculateScore(input);

            // Assert
            result.ShouldBe(expected);
        }
    }
}
