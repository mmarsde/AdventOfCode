using AdventOfCode._2022.Day1;
using AdventOfCode._2022.Helpers;
using Xunit;

namespace AdventOfCode._2022.Tests.Day1
{
    public class Day1SolutionTests
    {
        [Fact]
        public void Day1Solution_GetMaxCalorieCount_Returns_24000_From_ExampleData()
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
            var result = Day1Solution.GetMaxCalorieCount(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Day1Solution_GetMaxCalorieCount_Returns_73211_From_InputFileData()
        {
            // Arrange
            var file = Path.Combine("Inputs", "day1.txt");
            var input = File.ReadAllText(file);

            var expected = 73211;

            // Act
            var result = Day1Solution.GetMaxCalorieCount(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Day1Solution_GetTotalCalorieReserves_Returns_45000_From_ExampleData()
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
            var result = Day1Solution.GetTotalCalorieReserves(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Day1Solution_GetTotalCalorieReserves_Returns_213958_From_InputFileData()
        {
            // Arrange
            var input = ImportHelpers.ReadFile("day1.txt");

            var expected = 213958;

            // Act
            var result = Day1Solution.GetTotalCalorieReserves(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}