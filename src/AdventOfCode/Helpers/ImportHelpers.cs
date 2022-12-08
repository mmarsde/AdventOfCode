namespace AdventOfCode.Helpers
{
    public static class ImportHelpers
    {
        public static string ReadFile(string filename) => File.ReadAllText(Path.Combine("Inputs", filename));
    }
}
