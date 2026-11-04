namespace AgentName.Generator;

/// <summary>Optional user inputs, shared by all three eras so they survive tab switches.</summary>
public sealed class Inputs
{
    public string? Name { get; set; }
    public int? BirthYear { get; set; }
    public string County { get; set; } = "";
    public string Occupation { get; set; } = "";

    // Era-specific
    public string Show { get; set; } = "";
    public string FirstCar { get; set; } = "";
    public string Connection { get; set; } = "";
    public string Position { get; set; } = "";
    public string Holdudvar { get; set; } = "";
    public string MedievalMode { get; set; } = "";
    public string MedievalRole { get; set; } = "";
    public string MedievalCounty { get; set; } = "";

    /// <summary>First word of the name (Hungarian order: surname first), or null.</summary>
    public string? Surname
    {
        get
        {
            var n = Name?.Trim();
            if (string.IsNullOrEmpty(n)) return null;
            var space = n.IndexOf(' ');
            return space > 0 ? n[..space] : n;
        }
    }

    public string? Town => Array.Find(WordLists.Counties, c => c.County == County).Town;
}
