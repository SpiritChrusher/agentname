namespace AgentName.Generator;

/// <summary>Word pools for 1990–2010. Generated cases are fictional; ReferenceCases are well-known public affairs.</summary>
internal static class TransitionWords
{
    public static readonly string[] CaseNouns =
    [
        "Gumikesztyű", "Pálinka", "Konzervgyár", "Fürdőkád", "Szódavíz", "Tejpor", "Kockacukor", "Paprikaőrlő",
        "Bakelit", "Zsírkréta", "Lekvár", "Mákdaráló", "Videotéka", "Mobiltelefon", "Gázolaj", "Fűtőolaj",
        "Cipőkrém", "Szalámi", "Turistaház", "Zsebrádió", "Tévéantenna", "Üdülőcsekk", "Bálázó", "Kukoricadara",
        "Szőnyegpadló", "Strandpapucs", "Lottózó", "Hűtőmágnes", "Pezsgőgyár", "Ablakkeret",
    ];

    /// <summary>Pattern and whether it takes the definite article.</summary>
    public static readonly (string Pattern, bool Article)[] CasePatterns =
    [
        ("{0}-ügy", true),
        ("{0}-gate", false),
        ("Nagy {0}-privatizáció", true),
        ("{0}-botrány", true),
        ("{0}-mutyi", true),
        ("{0}-szőkítés", true),
        ("{0}-csomag", true),
    ];

    public static readonly string[] CompanyCores = ["Pannon", "Hungária", "Trans", "Euro", "Duna", "Kárpát", "Inter", "Magyar"];
    public static readonly string[] CompanyKinds = ["Holding", "Invest", "Trade", "Consulting", "Import-Export", "Vagyonkezelő"];
    public static readonly string[] CompanyForms = ["Bt.", "Kft.", "Rt."];

    public static readonly string[] Methods =
    [
        "spontán privatizáció (az igazgató megvette a gyárat a gyártól)",
        "kárpótlási jegyek felvásárlása névérték 10%-áért",
        "olajszőkítés: a fűtőolajból egy éjszaka alatt gázolaj lett",
        "fiktív számlák egy kamu cégláncon keresztül",
        "ÁFA-visszaigénylés soha meg nem épült raktárra",
        "brókerbotrány: a betétek „átmenetileg” máshol pihentek",
        "„tanácsadói szerződés” egy kétoldalas tanulmányért",
        "piramisjáték „garantált 30% havi hozammal”",
        "állami földcsere, csak kicsit rossz árfolyamon",
    ];

    public static readonly string[] Offshores =
    [
        "Ciprus", "Seychelle-szigetek", "Belize", "Brit Virgin-szigetek", "Liechtenstein", "Gibraltár",
        "egy bécsi bankszéf", "Panama", "a sógor pincéje",
    ];

    public static readonly string[] GenericVehicles =
    [
        "nejlonzacskó, kockás", "Postabank-széf", "egy Ikarus csomagtere", "sporttáska, Adidas-utánzat",
        "egy villanyóra-szekrény", "a nagymama befőttesüvegei",
    ];

    public sealed record Car(string Label, string Vehicle, bool Luxury);

    public static readonly Car[] Cars =
    [
        new("Lada", "egy Lada 1500 csomagtartója, a pótkerék alatt", false),
        new("Trabant", "egy Trabant hátsó ülése alatti üreg", false),
        new("Wartburg", "egy Wartburg Tourist tetőcsomagtartója", false),
        new("Suzuki Swift", "egy vadonatúj, esztergomi Suzuki Swift", false),
        new("Opel Astra", "egy fehér Opel Astra csomagtartója", false),
        new("BMW", "egy sötétített üvegű BMW", true),
        new("Mercedes", "egy fehér Mercedes, sofőrrel", true),
        new("Nem volt autóm", "BKV-bérlet és egy kockás nejlonzacskó", false),
    ];

    public static readonly string[] Outcomes =
    [
        "az ügy elévült",
        "a vádirat elveszett a költözéskor",
        "a bíróság bizonyítékok hiányában felmentett",
        "kitüntetést kaptál „a gazdaság átalakításáért”",
        "csak egy parlamenti vizsgálóbizottság lett belőle",
        "a cég felszámolás alatt áll — 1998 óta",
        "megúsztad egy közérdekű munkával: tanácsadó lettél",
    ];

    public static readonly string[] LuxuryOutcomes =
    [
        "a bíróság jogerősen felmentett",
        "az eljárást megszüntették, a BMW maradt",
        "kitüntetést kaptál „a gazdaság átalakításáért”",
    ];

    public static readonly Dictionary<string, string> RolesByOccupation = new()
    {
        ["Tanár"] = "a kárpótlásijegy-felvásárlás „pedagógiai szakértője”",
        ["Gyári munkás"] = "MRP-résztulajdonos, aki egy hét alatt mindent eladott",
        ["Mérnök"] = "a vagyonértékelés „független” szakértője",
        ["Pap / lelkész"] = "a cég lelki tanácsadója, havi apanázzsal",
        ["Sportoló"] = "az egyesület privatizálója — a pályát kiparcellázták",
        ["Színész"] = "a piramisjáték tévéreklámjának arca",
        ["Egyetemista"] = "fiatal strómann, aki csak aláírt",
        ["Orvos"] = "a rendelőintézet „kiszervezésének” haszonélvezője",
        ["Újságíró / író"] = "a leleplező riport szerzője — a cikk sosem jelent meg",
        ["TSZ-tag"] = "a TSZ-vagyon „átalakítója”",
        ["Bolti eladó"] = "az ÁFÉSZ-bolt egyik napról a másikra tulajdonosa",
        ["Nyugdíjas"] = "a cég papíron 84 éves ügyvezetője",
    };

    public static readonly string[] GenericRoles =
    [
        "strómann", "beltag", "kültag", "ügyvezető", "„tanácsadó”", "az igazgatósági tag sógora",
    ];

    /// <summary>Well-known public affairs, referenced by name and subject only.</summary>
    public static readonly string[] ReferenceCases =
    [
        "a Tocsik-ügy (1996, privatizációs sikerdíj)",
        "az olajszőkítési ügyek (90-es évek, fűtőolaj gázolajként)",
        "a Postabank-ügy (1998)",
        "a K&H brókerbotrány (2003)",
        "a BKV-ügyek (2009–2010)",
        "a 4-es metró építése",
        "a spontán privatizáció (1988–1990)",
        "a kárpótlási jegyek piaca (1991-től)",
        "a Zuschlag-ügy (2009)",
        "a sukorói telekcsere-ügy (2009)",
    ];

    public static readonly (string Year, string Label)[] Events =
    [
        ("1990", "Taxisblokád"),
        ("1991", "Kárpótlási törvény"),
        ("1990–", "Spontán privatizáció"),
        ("1990-es évek", "Olajszőkítés"),
        ("1995", "Bokros-csomag"),
        ("1996", "Tocsik-ügy"),
        ("1998", "Postabank-ügy"),
        ("2003", "K&H brókerbotrány"),
        ("2006", "Őszödi beszéd, utcai zavargások és rendőri fellépés"),
        ("2008", "Gazdasági világválság, IMF-hitel"),
        ("2009", "BKV-ügyek"),
        ("2006–2014", "4-es metró"),
    ];
}
