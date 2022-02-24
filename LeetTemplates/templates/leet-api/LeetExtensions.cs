public static class LeetExtensions
{
    private static readonly int[] _weights = new[] { 100, 300, 500, 700, 900 };
    private static readonly int[] _sizes = new[] { 1, 2, 3, 5, 7 };
    private static readonly string[] _colors = new[] { "#05e273", "#0c0c91", "#000", "#05e273" };

    public static IEnumerable<string> AddLeetWeights(this IEnumerable<string> values) =>
        values.Select(value => $"<span style=\"font-weight:{_weights[Random() % _weights.Length]};\">{value}</span>");

    public static IEnumerable<string> AddLeetSizes(this IEnumerable<string> values) =>
        values.Select(value => $"<span style=\"font-size:{_sizes[Random() % _sizes.Length]}rem;font-family: Arial, sans-serif;\">{value}</span>");

    public static IEnumerable<string> AddLeetColors(this IEnumerable<string> values) =>
        values.Select(value => $"<span style=\"color:{_colors[Random() % _colors.Length]};\">{value}</span>");

    public static string Join(this IEnumerable<string> values) =>
        string.Join(" ", values);

    private static readonly Random _random = new();
    private static readonly object _syncLock = new();
    private static int Random()
    {
        if (_syncLock != null)
            lock (_syncLock)
                return _random.Next(0, 100);
        return 0;
    }
}
