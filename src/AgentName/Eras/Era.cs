namespace AgentName.Eras;

public enum Era { Szoc, Rv, Ner }

public static class EraInfo
{
    public static readonly Era[] All = [Era.Szoc, Era.Rv, Era.Ner];

    public static string Hash(Era era) => era switch
    {
        Era.Rv => "rendszervaltas",
        Era.Ner => "ner",
        _ => "szocializmus",
    };

    public static string Key(Era era) => era switch
    {
        Era.Rv => "rv",
        Era.Ner => "ner",
        _ => "szoc",
    };

    public static string Years(Era era) => era switch
    {
        Era.Rv => "1990–2010",
        Era.Ner => "2010–2026",
        _ => "1957–1989",
    };

    public static string Label(Era era) => era switch
    {
        Era.Rv => "Rendszerváltás",
        Era.Ner => "NER",
        _ => "Szocializmus",
    };

    /// <summary>Era from a full URI's fragment; anything unknown falls back to the socialist era.</summary>
    public static Era FromUri(string uri)
    {
        var i = uri.IndexOf('#');
        var hash = i < 0 ? "" : uri[(i + 1)..];
        foreach (var era in All)
            if (hash == Hash(era)) return era;
        return Era.Szoc;
    }
}
