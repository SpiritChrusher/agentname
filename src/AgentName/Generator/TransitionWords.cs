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
        "Fagylaltgép", "Mosógép", "Varrógép", "Benzinkút", "Videokölcsönző", "Számítógép", "Pénztárgép",
        "Széf", "Kazetta", "Magnetofon", "Színes tévé", "Mosópor", "Téglagyár", "Húsüzem", "Baromfitelep",
        "Szeszüzem", "Nyomda", "Üveggyár", "Bútoráruház", "Szőnyegbolt", "Autómosó", "Parkolóház",
        "Halgazdaság", "Műtrágya", "Hűtőház",
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
        ("{0}-ügylet", true),
        ("{0}-biznisz", true),
        ("{0}-kör", true),
        ("{0}-panama", true),
        ("A nagy {0}-mutatvány", false),
    ];

    public static readonly string[] CompanyCores = ["Pannon", "Hungária", "Trans", "Euro", "Duna", "Kárpát", "Inter", "Magyar", "Alföld", "Balaton", "Kelet", "Nyugat"];
    public static readonly string[] CompanyKinds = ["Holding", "Invest", "Trade", "Consulting", "Import-Export", "Vagyonkezelő", "Kereskedőház", "Szolgáltató", "Ingatlan", "Finanszírozó"];
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
        "végelszámolás helyett „átalakulás”, ugyanazzal a cégszámmal",
        "vagyonkezelési szerződés egy vadásztársasággal",
        "külföldi „szakmai befektető” egy postafiók-cégen keresztül",
        "önkormányzati ingatlan cseréje bérelt helikopterre",
        "hitelkérelem saját magadhoz, kedvezményes kamattal",
        "adásvétel este 22:47-kor, közjegyző nélkül",
        "apport: egy tervrajz és két szóbeli ígéret",
        "bérleti szerződés a saját pincére, piaci ár tízszereséért",
        "„privatizációs tanácsadás” egy eredménytelen pályázat után",
        "készpénzben, de hivatalosan mégis átutalással",
        "két cég, egy titkárnő, nulla termelés",
        "a vevő és az eladó ugyanaz a személy, más kalapban",
        "osztalékelőleg a még meg sem termelt nyereségből",
        "végrehajtás alatt álló cég megvásárlása „jelképes” áron",
        "a telek felét eladtad, a másik felét elajándékoztad magadnak",
    ];

    public static readonly string[] Offshores =
    [
        "Ciprus", "Seychelle-szigetek", "Belize", "Brit Virgin-szigetek", "Liechtenstein", "Gibraltár",
        "egy bécsi bankszéf", "Panama", "a sógor pincéje",
        "Málta", "Monaco", "Andorra", "Svájc", "Hongkong",
        "a bécsi nagynéni lakása", "egy széfbérlő fiók a belvárosban",
    ];

    public static readonly string[] GenericVehicles =
    [
        "nejlonzacskó, kockás", "Postabank-széf", "egy Ikarus csomagtere", "sporttáska, Adidas-utánzat",
        "egy villanyóra-szekrény", "a nagymama befőttesüvegei",
        "egy hűtőkamion rakománya", "egy üdülői szekrény, a törölközők alatt",
        "egy lakótelepi garázs, a festékesvödrök mögött", "a vállalati könyvtár egyik lexikona (kivájt)",
        "egy postai csomag, „könyvek” megjelöléssel", "egy téesz-istálló szénapadlása",
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
        "a cég nyom nélkül felszámolódott",
        "az adóhivatalt is sikerült kikerülni — egy darabig",
        "két év múlva ugyanazt a céget nyitottad meg újra",
        "a tartozás szépen átkerült az új cégre",
        "a részvényeket a fiókban felejtették, és ott is maradtak",
        "a bíróság a cég törlését rendelte el, a vagyon addig eltűnt",
        "egy újságcikk lett belőle a 7. oldalon",
        "soha senki nem kérdezett semmit",
        "a jegyzőkönyv szerint minden szabályos volt",
        "a nyomozás a „fontosabb ügyek” miatt elmaradt",
        "a védőügyvéd maga is érintett volt",
    ];

    public static readonly string[] LuxuryOutcomes =
    [
        "a bíróság jogerősen felmentett",
        "az eljárást megszüntették, a BMW maradt",
        "kitüntetést kaptál „a gazdaság átalakításáért”",
        "az ügyet lezárták, a hajó a nevemre szólt",
        "a bíróság felmentett, a számlát a cég fizette",
        "a nyomozást megszüntették, a svájci számla megmaradt",
        "a vádiratot visszavonták, a nyaraló maradt",
        "kitüntetést kaptál, a vagyon pedig külföldön pihen",
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
        ["Titkárnő"] = "a cégjegyzék szerinti „irodavezető”, aki soha nem járt a székhelyen",
        ["Könyvtáros"] = "a vállalati könyvtár „felszámolásának” kezelője",
        ["Villanyszerelő"] = "az áramszolgáltató „átalánydíjas” partnere",
        ["Hentes"] = "a húsüzem privatizációjának első számú haszonélvezője",
    };

    public static readonly string[] GenericRoles =
    [
        "strómann", "beltag", "kültag", "ügyvezető", "„tanácsadó”", "az igazgatósági tag sógora",
        "„stratégiai tanácsadó”", "a cég papíron vezetője, gyakorlatban soha ott sem járt",
        "a könyvelő, aki mindent „rendben talált”", "az ügyvéd, aki a szerződést fogalmazta",
        "a szállító, aki soha nem szállított", "a cég egyetlen alkalmazottja, egyben tulajdonosa",
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
        "a Baumag-ügy (1996)",
    ];

    public static readonly (string Year, string Label)[] Events =
    [
        ("1990", "Taxisblokád"),
        ("1991", "Kárpótlási törvény"),
        ("1990–", "Spontán privatizáció"),
        ("1990-es évek", "Olajszőkítés"),
        ("1992", "Egzisztencia-hitel program"),
        ("1995", "Bokros-csomag"),
        ("1996", "Tocsik-ügy"),
        ("1997", "Hajdú-Bét és a mezőgazdasági cégek csődje"),
        ("1998", "Postabank-ügy"),
        ("2002", "Devizahitelek térhódítása"),
        ("2003", "K&H brókerbotrány"),
        ("2006", "Őszödi beszéd, utcai zavargások és rendőri fellépés"),
        ("2008", "Gazdasági világválság, IMF-hitel"),
        ("2009", "BKV-ügyek"),
        ("2006–2014", "4-es metró"),
    ];

    /// <summary>Dry, bureaucratic margin notes shown on the excerpt.</summary>
    public static readonly string[] Notes =
    [
        "A cég székhelye egy pizzéria címe, ahol senki nem hallott róla.",
        "Az ügyvéd és a közjegyző ugyanaz a személy, két különböző tollal.",
        "A mérleg két oldala közül csak az egyik van meg.",
        "A cégtáblát a nyitás előtti napon szerelték fel, a zárás után egy órával le.",
        "Az alapító okiratban a „tevékenység” rovatban valaki azt írta: „egyéb”.",
        "A könyvelés szerint nulla forgalom, a tulajdonos szerint „csak baráti segítség”.",
        "A bélyegző lenyomata három különböző céghez is tartozik.",
        "A cégjegyzékbe bejegyzett telefon száma egy virágbolté.",
        "A taggyűlési jegyzőkönyvön nincs dátum, de van rajta kávéfolt.",
        "Az éves beszámolót kétszer nyújtották be, először ceruzával.",
        "Az egyik aláírás olvashatatlan, a másik túl szép.",
        "A cégautó a könyvelésben „bicikliként” szerepel.",
        "A székhelyváltozásról szóló bejegyzés ugyanaznap kelt, mint a visszavonása.",
        "A vagyonmérlegben egy „egyéb eszköz” szerepel, összeg nélkül.",
        "Az üzleti terv egyetlen oldala egy fénymásolt étlap.",
        "A cégbejegyzéshez csatolták a szomszéd vállalkozó telefonszámát is.",
        "A záradékban: „a cég a jövőben nem végez semmilyen tevékenységet”.",
        "A pecsét a fiókban maradt, a szerződést mégis lezárták.",
        "A cég vezetője papíron 84 éves, telefonon viszont mindig fiatal hang.",
        "A zárszámadás szerint a nyereség „átszállt a következő évre”, és ott is maradt.",
    ];
}
