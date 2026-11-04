namespace AgentName.Generator;

/// <summary>Word pools for 2010–2026. Generated cases are fictional; ReferenceCases are well-known public affairs.</summary>
internal static class NerWords
{
    public sealed record Subject(string Noun, string Description);

    public static readonly Subject[] Subjects =
    [
        new("Napozóágy", "400 db napozóágy egy tó nélküli faluba"),
        new("Kilátó", "kilátó, ahonnan a következő kilátóra látni"),
        new("Kisvasút", "kisvasút, amely két szántóföld között jár"),
        new("LED-izzó", "közvilágítás-korszerűsítés egyetlen utcában"),
        new("Stadion", "4000 férőhelyes stadion egy 1200 lelkes faluban"),
        new("Lombkorona-sétány", "lombkorona-sétány fák nélkül"),
        new("Kastély", "kastélyfelújítás, amelynek a végén vadászház lett"),
        new("Tanulmány", "800 oldalas tanulmány, amelynek 790 oldala üres"),
        new("Szökőkút", "zenélő szökőkút a községháza előtt"),
        new("Térkő", "a főtér újratérkövezése (harmadszor)"),
        new("Kerékpárút", "kerékpárút, amely egy kukoricásban ér véget"),
        new("Rendezvénycsarnok", "rendezvénycsarnok, évi egy rendezvénnyel"),
        new("Templomtorony", "templomtorony-felújítás, LED-es kereszttel"),
        new("Varroda", "varroda, amely sosem varrt semmit"),
        new("Kalandpark", "kalandpark egy ártéri erdőben"),
    ];

    public static readonly (string Pattern, bool Article)[] CasePatterns =
    [
        ("{0}-közbeszerzés", true),
        ("{0}-projekt", true),
        ("{0}-gate", false),
        ("Nemzeti {0}-program", true),
        ("{0}-alapítvány", true),
        ("{0}-mutyi", true),
    ];

    public static readonly string[] FixedCaseNames =
    [
        "Kisvasút a semmibe",
        "a Kétszer Átadott Kilátó",
        "a Négyszer Felújított Főtér",
        "a Stadion a Stadion Mellett",
    ];

    public static readonly string[] WinnerCores = ["Nemzeti", "Kárpát", "Hungária", "Magyar", "Turul", "Szent Korona"];
    public static readonly string[] WinnerKinds = ["Építő", "Fejlesztő", "Beruházó", "Vagyonkezelő", "Közmű", "Projekt"];

    public sealed record Connection(string Label, string Asset, double Exponent);

    public static readonly Connection[] Connections =
    [
        new("Polgármester sógor", "balatoni nyaraló saját stéggel", 0),
        new("Egykori osztálytárs", "jacht az Adrián", 0.6),
        new("Focicsapat-társ", "VIP-páholy és egy saját futballakadémia", 0.4),
        new("Alapítványi kurátor", "kastély alapítványi tulajdonban, örök időkre", 0.8),
        new("Nincs senkim", "—", -1),
    ];

    public const string NoConnection = "Nincs senkim";

    public static readonly string[] GenericAssets =
    [
        "jacht az Adrián", "magánrepülő, „üzleti célra”", "vadászbirtok", "lovas tematikus park",
        "balatoni nyaraló saját stéggel", "egy kisebb szőlőbirtok Tokajban",
    ];

    public static readonly string[] Outcomes =
    [
        "az OLAF-jelentés a fiókban maradt",
        "a nyomozást „bűncselekmény hiányában” megszüntették",
        "a szerződést 2056-ig titkosították",
        "2026 után vizsgálat indult",
        "a projekt elnyerte az Év Beruházása díjat",
        "a kisvasút ma is jár — üresen",
        "az uniós támogatást végül visszafizették — adóforintokból",
    ];

    public static readonly Dictionary<string, string> RolesByOccupation = new()
    {
        ["Tanár"] = "az alapítványi egyetem kuratóriumi tagja",
        ["Gyári munkás"] = "az alvállalkozó alvállalkozójának alvállalkozója",
        ["Mérnök"] = "a megvalósíthatósági tanulmány „független” szerzője",
        ["Pap / lelkész"] = "az átadóünnepségek állandó szónoka",
        ["Sportoló"] = "a stadion névadója",
        ["Színész"] = "a kormányzati imázsfilm főszereplője",
        ["Egyetemista"] = "a kuratórium ösztöndíjasa",
        ["Orvos"] = "a kórházi parkoló-üzemeltetési pályázat nyertese",
        ["Újságíró / író"] = "a megyei lap főszerkesztője (az új tulajdonos alatt)",
        ["TSZ-tag"] = "földbérleti pályázat nyertese — a szomszéd nem is tudott róla",
        ["Bolti eladó"] = "trafikkoncesszió-tulajdonos",
        ["Nyugdíjas"] = "a cég 87 éves, papíron ügyvezető nagynénje",
    };

    public static readonly string[] GenericRoles =
    [
        "ügyvezető", "tanácsadó", "kuratóriumi tag", "alvállalkozó", "„független” műszaki ellenőr", "a nyertes sógora",
    ];

    /// <summary>Well-known public affairs, referenced by name and subject only.</summary>
    public static readonly string[] ReferenceCases =
    [
        "a letelepedési kötvények (2013–2017)",
        "a trafikkoncessziók (2013)",
        "az Elios-ügy (közvilágítás-korszerűsítés, OLAF-vizsgálat)",
        "a Vál-völgyi kisvasút (OLAF-vizsgálat)",
        "a stadionprogram (2014-től)",
        "az MNB-alapítványok (2014–2016)",
        "a KEKVA-alapítványok (2021)",
        "a Budapest–Belgrád vasútvonal titkosított szerződése",
        "a Pegasus-ügy (2021)",
    ];

    public static readonly (string Year, string Label)[] Events =
    [
        ("2010", "„Fülkeforradalom”, kétharmad"),
        ("2011", "Alaptörvény"),
        ("2013", "Letelepedési kötvények, trafikkoncessziók"),
        ("2014-től", "Stadionprogram"),
        ("2015", "Kerítés a déli határon"),
        ("2016", "MNB-alapítványok"),
        ("2021", "KEKVA-alapítványok, Pegasus-ügy"),
        ("2010–2026", "Kék plakátok"),
        ("2026", "Kormányváltás"),
    ];
}
