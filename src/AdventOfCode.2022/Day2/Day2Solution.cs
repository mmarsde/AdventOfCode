namespace AdventOfCode._2022.Day2
{
    public static class Day2Solution
    {
        public static int CalculateScore(string input)
        {
            return 
                GetNormalisedGameData(input)
                .Select(x => (OutcomeMultiplier(x.Player, x.Opponent) * 3) + x.Player + 1)
                .Sum();
        }

        private static(int Opponent, int Player)[] GetNormalisedGameData(string input)
        {
            return 
                input
                .Split(Environment.NewLine)
                .Select(item => item.Split(" ").SelectMany(items => items.ToCharArray()).ToArray())
                .Select(charItems => ((byte)charItems[0] - Convert.ToByte('A'), (byte)charItems[1] - Convert.ToByte('X')))
                .ToArray();
        }

        private static int OutcomeMultiplier(int player, int oponent)
        {
            var difference = player - oponent;

            return difference switch
            {
                2 => -1,
                -2 => 1,
                _ => difference
            } + 1;
        }

    }
}
