namespace AgentName.Generator;

internal static class Rng
{
    public static T Pick<T>(this Random rng, T[] items) => items[rng.Next(items.Length)];

    public static bool Chance(this Random rng, double p) => rng.NextDouble() < p;

    /// <summary>Log-uniform amount between 10^minExp and 10^maxExp, rounded to <paramref name="roundTo"/>.</summary>
    public static long LogAmount(this Random rng, double minExp, double maxExp, long roundTo)
    {
        var value = Math.Pow(10, minExp + rng.NextDouble() * (maxExp - minExp));
        return Math.Max(roundTo, (long)Math.Round(value / roundTo) * roundTo);
    }

    /// <summary>Prefixes the Hungarian definite article: "a Fecske-ügy", "az Ablakkeret-ügy".</summary>
    public static string WithArticle(string phrase) =>
        ("AÁEÉIÍOÓÖŐUÚÜŰaáeéiíoóöőuúüű".Contains(phrase[0]) ? "az " : "a ") + phrase;

    /// <summary>"12 500 000 Ft" with narrow no-break spaces; culture-independent (InvariantGlobalization).</summary>
    public static string FormatHuf(long amount)
    {
        var digits = amount.ToString(System.Globalization.CultureInfo.InvariantCulture);
        var sb = new System.Text.StringBuilder(digits.Length + digits.Length / 3 + 3);
        for (var i = 0; i < digits.Length; i++)
        {
            if (i > 0 && (digits.Length - i) % 3 == 0) sb.Append(' ');
            sb.Append(digits[i]);
        }
        return sb.Append(" Ft").ToString();
    }
}
