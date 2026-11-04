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
        new("Tornaterem", "tornaterem, amelynek a plafonja alacsonyabb, mint az ajtó"),
        new("Uszoda", "uszoda, amelybe a víz külön pályázaton érkezik"),
        new("Múzeum", "múzeum, amelynek a kiállításai a raktárban vannak"),
        new("Vadászház", "vadászház, ahová csak terepjáróval lehet bejutni"),
        new("Konferenciaközpont", "konferenciaközpont, évi egy tájékoztatóval"),
        new("Parkoló", "parkolóház, ahol a mozgólépcső nem működik"),
        new("Híd", "gyalogoshíd, amely a szomszéd faluhoz vezet"),
        new("Bobpálya", "bobpálya hó nélkül, műbobbal"),
        new("Sífutópálya", "sípálya egy domboldalon, hóágyú nélkül"),
        new("Óvoda", "óvoda, amelynek az udvara egy parkoló"),
        new("Iskola", "iskolafelújítás, ahol a tornaterem maradt el"),
        new("Kórház", "kórházparkoló, díj ellenében"),
        new("Lovarda", "lovarda, ahol a lovak külföldön versenyeznek"),
        new("Szoborpark", "szoborpark, három szoborral és hét talapzattal"),
        new("Csónakház", "csónakház egy feltöltött holtág partján"),
    ];

    public static readonly (string Pattern, bool Article)[] CasePatterns =
    [
        ("{0}-közbeszerzés", true),
        ("{0}-projekt", true),
        ("{0}-gate", false),
        ("Nemzeti {0}-program", true),
        ("{0}-alapítvány", true),
        ("{0}-mutyi", true),
        ("{0}-beruházás", true),
        ("{0}-fejlesztés", true),
        ("{0}-támogatás", true),
        ("{0}-szerződés", true),
        ("Nemzeti {0}-tanulmány", true),
    ];

    public static readonly string[] FixedCaseNames =
    [
        "Kisvasút a semmibe",
        "a Kétszer Átadott Kilátó",
        "a Négyszer Felújított Főtér",
        "a Stadion a Stadion Mellett",
        "a Kétszer Átadott Tornaterem",
        "a Soha El Nem Készült Uszoda",
        "a Múzeum, Amelynek Nincs Kiállítása",
        "a Híd a Semmihez",
        "a Bobpálya Hó Nélkül",
        "a Szoborpark a Talapzatokkal",
    ];

    public static readonly string[] WinnerCores = ["Nemzeti", "Kárpát", "Hungária", "Magyar", "Turul", "Szent Korona", "Alföld", "Duna", "Balaton", "Kelet"];
    public static readonly string[] WinnerKinds = ["Építő", "Fejlesztő", "Beruházó", "Vagyonkezelő", "Közmű", "Projekt", "Kereskedőház", "Szolgáltató", "Ingatlan", "Tanácsadó"];

    public sealed record Connection(string Label, string Asset, double Exponent);

    public static readonly Connection[] Connections =
    [
        new("Polgármester sógor", "balatoni nyaraló saját stéggel", 0),
        new("Egykori osztálytárs", "jacht az Adrián", 0.6),
        new("Focicsapat-társ", "VIP-páholy és egy saját futballakadémia", 0.4),
        new("Alapítványi kurátor", "kastély alapítványi tulajdonban, örök időkre", 0.8),
        new("Önkormányzati képviselő", "önkormányzati ingatlan, jelképes bérleti díjjal", 0.2),
        new("Média-tulajdonos", "regionális tévé és egy rádió", 0.6),
        new("Közbeszerzési tanácsadó", "iroda a Duna-parton, üvegfallal", 0.7),
        new("Nincs senkim", "—", -1),
    ];

    public const string NoConnection = "Nincs senkim";

    public static readonly string[] GenericAssets =
    [
        "jacht az Adrián", "magánrepülő, „üzleti célra”", "vadászbirtok", "lovas tematikus park",
        "balatoni nyaraló saját stéggel", "egy kisebb szőlőbirtok Tokajban",
        "tokaji dűlő, saját pincével", "balatoni vitorlás, kikötőhely nélkül",
        "hegyi ház, panorámával és úttal", "hegyi vadászház, saját leshellyel",
        "kollekció: régi autók, zárt garázsban", "golfpálya melletti villa",
        "borturisztikai birtok, uniós támogatással", "saját repülőtér-részvény, jelképesen",
        "hotelrészesedés a Dunakanyarban", "traktorflotta, bérbe adva",
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
        "az ajánlatkérő „elfelejtette” közzétenni a szerződést",
        "a bírálatot a második körben is ugyanaz a bizottság írta",
        "az uniós forrásból a kerítés is belefért",
        "a létesítmény átadásán a szalagot kétszer vágták át",
        "a projektgazda cég időközben megszűnt, a számla megmaradt",
        "a szerződés 1. melléklete 400 oldal, a 2. üres",
        "a felügyelőbizottság jelentése sosem készült el",
        "a fenntartásra már nem jutott — a projekt ettől szép",
        "a kivitelező a saját testvérének adta alvállalkozásba",
        "az átadás után három hónappal bezárták",
        "a közbeszerzési értesítőben a nyertes nevét elírták",
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
        ["Titkárnő"] = "a közbeszerzési osztály adminisztrátora, aki a határidőket „felejtette”",
        ["Könyvtáros"] = "a megyei könyvtárfelújítás műszaki ellenőre",
        ["Villanyszerelő"] = "a közvilágítás-korszerűsítés alvállalkozója",
        ["Hentes"] = "a kórházi étkeztetés beszállítója",
    };

    public static readonly string[] GenericRoles =
    [
        "ügyvezető", "tanácsadó", "kuratóriumi tag", "alvállalkozó", "„független” műszaki ellenőr", "a nyertes sógora",
        "a projektgazda cég ügyvezetője", "a műszaki ellenőr, aki soha nem járt a helyszínen",
        "a kommunikációs tanácsadó, aki a sajtóanyagot írta", "a lebonyolító, aki egyben az ajánlattevő",
        "a fenntartó alapítvány kurátora", "az alvállalkozó, akinek a nevét nem írták ki",
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
        "a Quaestor-botrány (2015)",
        "a Buda-Cash-botrány (2015)",
        "a Norvég Civil Alap körüli vizsgálatok (2014)",
    ];

    public static readonly (string Year, string Label)[] Events =
    [
        ("2010", "„Fülkeforradalom”, kétharmad"),
        ("2011", "Alaptörvény"),
        ("2013", "Letelepedési kötvények, trafikkoncessziók"),
        ("2014-től", "Stadionprogram"),
        ("2015", "Kerítés a déli határon"),
        ("2015", "Quaestor- és Buda-Cash-botrány"),
        ("2016", "MNB-alapítványok"),
        ("2017", "Civil törvény, „Stop Soros”"),
        ("2020", "Koronavírus-válság, rendkívüli felhatalmazás"),
        ("2021", "KEKVA-alapítványok, Pegasus-ügy"),
        ("2010–2026", "Kék plakátok"),
        ("2026", "Kormányváltás"),
    ];

    /// <summary>Dry, bureaucratic margin notes shown on the award notice.</summary>
    public static readonly string[] Notes =
    [
        "A közbeszerzési dokumentációt két oldalon kézírással pótolták.",
        "A bírálóbizottság üléséről nem készült jegyzőkönyv, mert „nem volt miről”.",
        "A szerződésmódosítások száma: 7, mindegyik ugyanarra a napra kelt.",
        "A nyertes ajánlat postabélyegzője későbbi, mint a beadási határidő.",
        "Az ajánlat egyik oldala fénymásolat, a másik szövegszerkesztőből kinyomtatva.",
        "A projekt honlapja 2019 óta „hamarosan” indul.",
        "A műszaki leírás egy korábbi, másik település pályázatából származik.",
        "A helyszíni szemléről készült fotókon csak a kerítés látszik.",
        "A kifizetési kérelem melléklete egy éttermi számla.",
        "Az indokolás minden pontja ugyanazzal a mondattal kezdődik.",
        "A nyilatkozatot aláíró személy a cégjegyzék szerint nem is létezik.",
        "A közbeszerzési értesítőben a becsült érték elmaradt.",
        "A projekt zárójelentése három oldal, ebből kettő a borító.",
        "Az átadóünnepség költsége a beruházás 12%-a.",
        "A pótmunka indoklása: „a helyzet úgy hozta”.",
        "A műszaki átadáson a villany még nem volt bekapcsolva.",
        "A fenntartási kötelezettségről szóló nyilatkozat keltezés nélkül maradt.",
        "Az uniós ellenőrzés előtt a dosszié egy éjszaka alatt kiegészült.",
        "A szerződés egy példánya a nyomdában maradt, a másik „elkallódott”.",
        "A projekt címe háromféleképpen szerepel a dokumentumokban.",
    ];
}
