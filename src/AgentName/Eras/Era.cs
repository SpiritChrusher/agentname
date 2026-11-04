namespace AgentName.Eras;

public enum Era { Kozepkor, Szoc, Rv, Ner, Nvvh }

public static class EraInfo
{
    public static readonly Era[] All = [Era.Kozepkor, Era.Szoc, Era.Rv, Era.Ner, Era.Nvvh];

    public static string Hash(Era era) => era switch
    {
        Era.Kozepkor => "kozepkor",
        Era.Rv => "rendszervaltas",
        Era.Ner => "ner",
        Era.Nvvh => "vagyonvisszaszerzes",
        _ => "szocializmus",
    };

    public static string Key(Era era) => era switch
    {
        Era.Kozepkor => "med",
        Era.Rv => "rv",
        Era.Ner => "ner",
        Era.Nvvh => "nvvh",
        _ => "szoc",
    };

    public static string Years(Era era) => era switch
    {
        Era.Kozepkor => "1000–1526",
        Era.Rv => "1990–2010",
        Era.Ner => "2010–2026",
        Era.Nvvh => "2026–",
        _ => "1957–1989",
    };

    public static string Label(Era era) => era switch
    {
        Era.Kozepkor => "Középkor",
        Era.Rv => "Rendszerváltás",
        Era.Ner => "NER",
        Era.Nvvh => "Vagyonvisszaszerzés",
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
