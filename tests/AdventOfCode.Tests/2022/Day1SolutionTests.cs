using AdventOfCode._2022.Day1;
using AdventOfCode.Helpers;
using Shouldly;
using Xunit;

namespace AdventOfCode.Tests._2022
{
    public class Day1SolutionTests
    {
        [Fact]
        public void Solution1_GetMaxCalorieCount_Returns_24000_From_ExampleData()
        {
            // Arrange
            var input = @"1000
                        2000
                        3000

                        4000

                        5000
                        6000

                        7000
                        8000
                        9000

                        10000
                        ";

            var expected = 24000;

            // Act
            var result = Day1Solution.GetTotalCalories(input);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Solution1_GetMaxCalorieCount_Returns_73211_From_InputFileData()
        {
            // Arrange
            var file = Path.Combine("Inputs", "day1.txt");
            var input = File.ReadAllText(file);

            var expected = 73211;

            // Act
            var result = Day1Solution.GetTotalCalories(input);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Solution2_GetTotalCalorieReserves_Returns_45000_From_ExampleData()
        {
            // Arrange
            var input = @"1000
                        2000
                        3000

                        4000

                        5000
                        6000

                        7000
                        8000
                        9000

                        10000
                        ";

            var expected = 45000;

            // Act
            var result = Day1Solution.GetTotalCalories(input, 3);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Solution2_GetTotalCalorieReserves_Returns_213958_From_InputFileData()
        {
            // Arrange
            var input = ImportHelpers.ReadFile("day1.txt");

            var expected = 213958;

            // Act
            var result = Day1Solution.GetTotalCalories(input, 3);

            // Assert
            result.ShouldBe(expected);
        }
    }
}