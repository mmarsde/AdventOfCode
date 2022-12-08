namespace AdventOfCode._2022.Day1
{
    public static class Day1Solution
    {
        public static int GetMaxCalorieCount(string input) => GetCalories(input).Max();

        public static int GetTotalCalorieReserves(string input)
        {
            return
                GetCalories(input)
                .OrderByDescending(item => item)
                .Take(3)
                .ToList()
                .Sum();
        }

        private static List<int> GetCalories(string input)
        {
            return
                input
                .Split(Environment.NewLine + Environment.NewLine)
                    .Select(item =>
                        item
                        .Split(Environment.NewLine)
                        .Select(item => int.TryParse(item.Trim(), out var result) ? result : 0)
                        .ToList()
                        .Sum())
                .ToList();
        }
    }
}

