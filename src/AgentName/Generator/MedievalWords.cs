namespace AgentName.Generator;

/// <summary>Word pools for the medieval era. Generated cases are fictional; reference events are public history.</summary>
internal static class MedievalWords
{
    public const string RoyalMode = "Királyi ítélet";
    public const string RebellionMode = "Parasztlázadás";

    public sealed record Mode(string Label, string Period, string AccusationTitle, string DetailTitle, string OutcomeTitle);

    public static readonly Mode[] Modes =
    [
        new(RoyalMode, "Szent István kora (1000–1038)", "A vád", "Az ügy", "Az ítélet"),
        new(RebellionMode, "Dózsa kora (1514)", "A panasz", "A követelésed", "A sorsod"),
    ];

    public sealed record Role(string Label, string Detail);

    public static readonly string[] Counties =
    [
        "Pest", "Fejér", "Borsod", "Zemplén", "Szabolcs", "Bihar", "Csongrád", "Bács",
        "Baranya", "Somogy", "Veszprém", "Győr", "Sopron", "Vas", "Zala", "Nógrád",
        "Heves", "Nyitra", "Pozsony", "Kolozs",
    ];

    public static readonly Role[] Roles =
    [
        new("jobbágy", "a földesúr dézsmáját viszed, az úr pedig a szomszédé"),
        new("nemes", "egy vármegyei per és egy elzálogosított birtok részese"),
        new("pap", "a tizedet magyarázod, miközben a harangot félreverik"),
        new("deák (clericus)", "a pecséteket fogalmazod, a hibákat mások fizetik meg"),
        new("városi polgár", "a vásár jogait kéred, a vámot viszont nem fizeted"),
        new("zsoldos (miles)", "a zsoldod elmaradt, a kardod nem"),
        new("iparos", "a céh kiváltságaira hivatkozol, a malomra is"),
        new("apát (abbas)", "a kolostor birtokait kezeled, a szomszéd nemes szerint túl jól"),
    ];

    public static readonly string[] RoyalAccusations =
    [
        "a király pecsétjének (sigillum) hamisítása",
        "a só (sal) útjának eltérítése",
        "a tized (decima) elrejtése",
        "a szomszéd nemes birtokának (terra) elfoglalása",
        "a vármegye adójának (census) elsikkasztása",
        "a templom kincsének eltüntetése",
        "a korona elleni szövetkezés",
        "hamis tanúzás a megyegyűlésen",
        "a várőrség zsoldjának eltitkolása",
        "erdőirtás a király vadászterületén (silva)",
        "a malom (molendinum) jogtalan használata",
        "a piaci vám (thelonium) kétszeri beszedése",
    ];

    public static readonly string[] RoyalDetails =
    [
        "a pecsét viasza még meg sem száradt, amikor a levél megérkezett",
        "a sót éjjel, szekéren vitték a szomszéd megyébe",
        "a tizedet borban fizették, a bordézsa alján víz volt",
        "a birtokhatár köveit egy éjszaka alatt másfél lépéssel odébb rakták",
        "a számadásban a „költségek” rovatban csak egy vonal szerepelt",
        "a templom kincsét a sekrestyés „megőrzésre” vitte magához",
        "a vármegye jegyzője ugyanaz volt, aki a vádat fogalmazta",
        "a tanút háromszor hallgatták ki, mindháromszor ugyanazt mondta, mégis mást írtak le",
        "a vár kapuját éjjel nyitva hagyták, a zsold viszont eltűnt",
        "az erdőből kivágott fát a saját portádra fuvaroztad, tengelyen",
    ];

    public static readonly string[] RoyalVerdicts =
    [
        "megvakítás — a király „kegyelme”",
        "száműzés az országból, vagyonelkobzással",
        "jobbágysorba vetés a királyi birtokon",
        "fülcsonkítás és pénzbírság",
        "száz ezüstmárka bírság, fizetésre tíz nap",
        "kard általi halál a várudvaron",
        "a vár börtönében öt év, víz és kenyér",
        "a vagyon elkobzása, a család szétszórása",
        "megbélyegzés és zarándoklat Rómába",
        "a per újrafelvétele — a vádlott költségére",
    ];

    /// <summary>Deliberately anachronistic verdicts; the chronicler is blamed in the text.</summary>
    public static readonly string[] AnachronisticVerdicts =
    [
        "felnégyelés — a krónikás anakronizmusa (ekkor még nem volt szokás)",
        "kerékbe törés — a krónikás anakronizmusa (későbbi századokból emlékszik)",
        "máglya — a krónikás anakronizmusa (a későbbi korokból kölcsönözte)",
    ];

    public static readonly string[] RebellionGrievances =
    [
        "a dézsma dupláját követelték",
        "a földesúr elvette a szántót, a maradványon is rajta volt a pecsét",
        "a zsoldosok nem kaptak fizetést, de a falutól ettek",
        "a város kapuját bezárták a menekülők előtt",
        "a pap a tizedet borban követelte, a bor pedig elfogyott",
        "a nemes perbe hívott egy malom miatt, amit a falu épített",
        "a só árát felemelték, a kenyérét nem",
        "a török adót is behajtották, a törököt nem látták",
        "a szekereseket elfogták az országúton, a vámot kétszer fizették",
        "a falut felégették a martalócok, a bíró csak a saját házát sajnálta",
        "a bíró a sógorának ítélte a legelőt",
        "a harangot elvitték, a papot is, a tizedet viszont behajtották",
    ];

    public static readonly string[] RebellionSlogans =
    [
        "„A dézsma a népé!”",
        "„Kenyeret és földet!”",
        "„Nem adunk tizedet!”",
        "„A malom a falué!”",
        "„Dózsa nevében!”",
        "„Szabad parasztot!”",
        "„A nemes is fizessen adót!”",
        "„A só szabad legyen!”",
        "„A harang maradjon!”",
        "„A bírót a falu válassza!”",
    ];

    public static readonly string[] RebellionOutcomes =
    [
        "a sereg szétoszlott, a vezért elfogták",
        "a királyi had leverte a felkelést",
        "a vezér felnégyeltetett — Dózsa sorsa szerint",
        "a krónikás hősként írta meg, a vármegye ellenségként",
        "a falvakban még évekig emlegették",
        "a nemesek birtokai megmaradtak, a falvak nem",
        "a vezér kegyelmet kapott — papíron",
        "a tizedet végül mégis beszedték",
        "a csata után mindenki hazament aratni",
        "a felkelésből monda lett, a dézsmából adó",
    ];

    public static readonly string[] RoyalNotes =
    [
        "A krónika szerint a király „irgalmas volt, mert csak egy szemét vette ki”.",
        "A jegyző a nevedet rosszul írta, a büntetést viszont pontosan.",
        "A tanúk száma három, a vallomások száma öt.",
        "A pecsét alatt másik pecsét van, az alatt egy harmadik.",
        "A krónikás szerint az eső mosta el a határköveket, nem a szomszéd.",
        "A per jegyzőkönyve hiányos, a büntetés végrehajtása annál pontosabb.",
        "A vádlott „önként” vallott, a jegyző szerint kétszer.",
        "A tanú a szomszéd volt, a bíró a szomszéd testvére.",
        "Az ítélet napján a harang elromlott, a hóhér viszont időben megérkezett.",
        "A birtokot a vármegye lefoglalta, majd saját magának adta bérbe.",
        "A krónika két oldalt szentel az ügynek, a vádlott egy sort.",
        "A falu népe szerint minden rendben volt; a falu népe nem szerepel a jegyzőkönyvben.",
    ];

    public static readonly string[] RebellionNotes =
    [
        "A felkelés okai között a krónika a rossz időjárást is említi — természetesen.",
        "A vezér beszéde három oldal, a kivégzés két sor.",
        "A falu népe szerint minden rendben volt; a falu népe nem szerepel a jegyzőkönyvben.",
        "A krónika két oldalt szentel az ügynek, a vádlott egy sort.",
        "A dézsma behajtása gyorsabb volt, mint a felkelés leverése.",
        "A krónikás szerint a nép „jókedvűen” vonult fel, a nyilak viszont nem voltak azok.",
        "A nemesek listája hiányzik, a kártérítésük annál pontosabb.",
        "A felkelés vezérének nevét a krónika háromféleképpen írja.",
        "A győztesek krónikája rövid, a vesztesek emlékezete hosszú.",
        "A tizedet végül beszedték; a krónika ezt „rend helyreállásának” nevezi.",
        "A bíró a saját malmát féltette, a faluét nem.",
        "A sereg létszáma a krónikában kétszer akkora, mint a zsoldjegyzéken.",
    ];

    public static readonly string[] CaseNouns =
    [
        "Sal", "Molendinum", "Sigillum", "Terra", "Decima", "Currus", "Pascuum", "Vineae",
        "Gladius", "Clypeus", "Monasterium", "Forum", "Thelonium", "Pons", "Silva", "Piscina",
        "Cellarium", "Campana", "Liber", "Vexillum",
    ];

    /// <summary>Pattern and whether it takes the definite article.</summary>
    public static readonly (string Pattern, bool Article)[] CasePatterns =
    [
        ("{0}-ügy", true),
        ("{0}-per", true),
        ("A {0}-vád", false),
        ("{0}-panasz", true),
        ("A nagy {0}-per", false),
        ("{0}-carta", true),
    ];

    public static readonly string[] FixedCaseNames =
    [
        "a Sal és a Sigillum",
        "a Molendinum-per",
        "a Currus-ügy",
        "a Campana és a Decima",
    ];

    /// <summary>Well-known public events and sources, referenced by name and subject only.</summary>
    public static readonly string[] RoyalReferenceCases =
    [
        "Szent István törvényei (1000–1038)",
        "Vata-felkelés (1046)",
        "Váradi Regestrum (1208–1235)",
        "Aranybulla (1222)",
        "Tatárjárás (1241–1242)",
    ];

    public static readonly string[] RebellionReferenceCases =
    [
        "Dózsa-felkelés (1514)",
        "Werbőczy: Hármaskönyv (1517)",
        "A dézsma és a kilenced (14–15. század)",
        "A sókereskedelem és a harmincadvám (14–15. század)",
    ];

    public static readonly (string Year, string Label)[] Events =
    [
        ("1000", "Szent István megkoronázása"),
        ("1038", "István halála"),
        ("1046", "Vata-felkelés"),
        ("1222", "Aranybulla"),
        ("1241–42", "Tatárjárás"),
        ("1456", "Nándorfehérvár"),
        ("1514", "Dózsa parasztfelkelése"),
        ("1526", "Mohács"),
    ];
}
