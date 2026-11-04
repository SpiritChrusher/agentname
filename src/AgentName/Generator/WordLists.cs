namespace AgentName.Generator;

/// <summary>
/// Fictional word pools. Only generic Hungarian words — no names taken from real released files.
/// </summary>
internal static class WordLists
{
    public static readonly string[] Nouns =
    [
        // madarak
        "Fecske", "Rigó", "Vércse", "Héja", "Bagoly", "Szarka", "Csóka", "Holló", "Gerle", "Pacsirta",
        "Sólyom", "Cinege", "Harkály", "Vadgalamb", "Kakukk", "Fülemüle", "Seregély", "Gólya",
        // természet
        "Tavasz", "Szellő", "Nyárfa", "Akác", "Gesztenye", "Hóvirág", "Ibolya", "Tölgy", "Patak", "Szamóca",
        "Bodza", "Moha", "Zúzmara", "Hajnal", "Alkony", "Zivatar", "Platán", "Csalán",
        // tárgyak
        "Hegedű", "Írógép", "Szifon", "Rádió", "Pipa", "Esernyő", "Kalap", "Ceruza", "Kulcscsomó",
        "Tranzisztor", "Lemezjátszó", "Svájcisapka", "Bőrönd", "Zsebkendő", "Diafilm", "Bakelit",
        "Kávédaráló", "Szódásüveg", "Kockacukor", "Gyufásdoboz", "Teáskanna", "Villanyborotva",
        // foglalkozásszerű
        "Postás", "Mozigépész", "Kalauz", "Portás", "Hegedűs", "Kertész", "Asztalos", "Pék", "Sakkozó",
        "Vasutas", "Horgász", "Bélyeggyűjtő",
        // keresztnév-szerű
        "Pista", "Ferkó", "Jóska", "Marika", "Böske", "Lajcsi", "Gyurka", "Juliska", "Bandi", "Kati",
        // egyéb
        "Bizalom", "Remény", "Kilátó", "Iránytű", "Visszhang", "Árnyék", "Ködös", "Délibáb", "Kristály",
    ];

    public static readonly string[] Adjectives =
    [
        "Szürke", "Csendes", "Fürge", "Hallgatag", "Éber", "Ravasz", "Öreg", "Kis", "Vörös", "Fekete",
        "Szorgalmas", "Ködös", "Hűséges", "Álmos", "Kíváncsi", "Szerény", "Pontos", "Mosolygós",
        "Bajuszos", "Szemüveges", "Hajnali", "Éjféli", "Őszi", "Zöld",
    ];

    public sealed record Show(string Label, string[] Nouns, string Remark);

    public static readonly Show[] Shows =
    [
        new("Mazsola", ["Mazsola", "Manócska", "Tádé"],
            "Fokozott ellenőrzés mellett megbízható. Kedvenc mondata: „Manócska, Manócska!”"),
        new("Pom Pom meséi", ["Pom Pom", "Picur", "Gombóc"],
            "Hajlamos eltűnt csokoládéról fantáziálni (lásd: Gombóc Artúr-ügy)."),
        new("Vízipók-csodapók", ["Vízipók", "Keresztes", "Szitakötő"],
            "Jelentéseit kizárólag a víz alól, légbuborékban adja le."),
        new("Frakk, a macskák réme", ["Frakk", "Lukrécia", "Szerénke"],
            "Két macskát rendszeresen megfigyel. A macskák mindent tagadnak."),
        new("A Mézga család", ["Aladár", "Blöki", "Hufnágel"],
            "Állítása szerint egy MZ/X nevű kapcsolattól kap információt a 30. századból. Ellenőrizendő."),
        new("Kockásfülű nyúl", ["Kockás", "Tapsi", "Nyuszi"],
            "Feltűnő külseje miatt fedett munkára csak korlátozottan alkalmas."),
        new("Mekk Elek, az ezermester", ["Ezermester", "Mekk", "Kecske"],
            "Mindenhez ért, mindent elront — a lehallgatókészüléket is."),
        new("Süsü, a sárkány", ["Süsü", "Királyfi", "Sárkány"],
            "Csak egy feje van, ezért fele annyi jelentést ír, mint elvárható."),
        new("Dr. Bubó", ["Bubó", "Doktor", "Bagoly"],
            "Diagnózisai pontatlanok, jelentései viszont rendkívül hosszúak."),
        new("Vuk", ["Vuk", "Karak", "Rókalyuk"],
            "Ravasz. Sajnos a vadász is."),
        new("Esti mese (más)", [],
            "Minden este 19:30-kor tévé elé ül, ezért a találkozókat ehhez kell igazítani."),
    ];

    public sealed record Occupation(string Label, string[] Targets, string? Department);

    public static readonly Occupation[] Occupations =
    [
        new("Tanár", ["a tantestület nyugatra vágyó tagjai", "az iskolai faliújság gyanúsan szellemes cikkei"], "BM III/III-2. osztály"),
        new("Gyári munkás", ["a művezető, aki szerint a norma túl magas", "a szakszervezeti bizalmi és a büfés"], "BM III/III-4. osztály"),
        new("Mérnök", ["a tervezőiroda kávéfőző körül gyülekező csoportja", "egy kolléga, aki nyugati szaklapot olvas"], "BM III/II. osztály"),
        new("Pap / lelkész", ["a vasárnapi hittan résztvevői", "a kórus basszus szólama"], "BM III/III-1. osztály"),
        new("Sportoló", ["a válogatott keret, különösen külföldi edzőtáborok előtt", "a szertáros, aki túl sokat utazik"], "BM III/III-4. osztály"),
        new("Színész", ["a színház büféje, ahol politikai vicceket mesélnek", "a súgó, aki többet tud, mint mond"], "BM III/III-3. osztály"),
        new("Egyetemista", ["a kollégiumi szobatársak", "az évfolyam gitáros, szakállas tagjai"], "BM III/III-2. osztály"),
        new("Orvos", ["a kórház portása, aki mindent tud", "a hálapénzt nyugati valutában kérő kollégák"], "BM III/III-4. osztály"),
        new("Újságíró / író", ["a szerkesztőség ironikus hangvételű rovatvezetője", "a kéziratok között lapuló szamizdat"], "BM III/III-3. osztály"),
        new("TSZ-tag", ["a szomszéd háztáji gyanúsan jó paprikatermése", "a brigádvezető, aki nyugati traktorról álmodik"], "BM III/III-4. osztály"),
        new("Bolti eladó", ["a pult alól árult banán vásárlói", "a vevők, akik Trapper farmert keresnek"], "BM III/III-4. osztály"),
        new("Nyugdíjas", ["a lépcsőház lakói, különös tekintettel a 3. emeletre", "a piaci padon ülő sakkozók"], "BM III/III-4. osztály"),
    ];

    public static readonly (string County, string Town)[] Counties =
    [
        ("Budapest", "Budapest"), ("Baranya", "Pécs"), ("Bács-Kiskun", "Kecskemét"), ("Békés", "Békéscsaba"),
        ("Borsod-Abaúj-Zemplén", "Miskolc"), ("Csongrád", "Szeged"), ("Fejér", "Székesfehérvár"),
        ("Győr-Sopron", "Győr"), ("Hajdú-Bihar", "Debrecen"), ("Heves", "Eger"), ("Komárom", "Tatabánya"),
        ("Nógrád", "Salgótarján"), ("Pest", "Szentendre"), ("Somogy", "Kaposvár"),
        ("Szabolcs-Szatmár", "Nyíregyháza"), ("Szolnok", "Szolnok"), ("Tolna", "Szekszárd"),
        ("Vas", "Szombathely"), ("Veszprém", "Veszprém"), ("Zala", "Zalaegerszeg"),
    ];

    public static readonly string[] TownMeetingPlaces =
    [
        "{0}, a vasútállomás restijében, a fikusz mögötti asztalnál",
        "{0}, a Centrum Áruház játékosztályán",
        "{0}, a Május 1. téren, a harmadik padon",
        "{0}, a Kossuth mozi második sorában, a híradó alatt",
        "{0}, a cukrászda pultjánál, két krémes között",
    ];

    public static readonly string[] GenericMeetingPlaces =
    [
        "az „Orgona” fedőnevű konspirációs lakás",
        "egy Balaton-parti SZOT-üdülő büféje",
        "egy zöld Trabant hátsó ülése",
        "a Népstadion B-szektora, félidőben",
        "a lakótelepi ABC tejpultja",
        "egy villamosmegálló, mindig a hatoson",
    ];

    public static readonly string[] GenericTargets =
    [
        "a lépcsőház lakói, különös tekintettel a 3. emeletre",
        "a szomszéd, aki gyanúsan sokat hallgatja a Szabad Európa Rádiót",
        "a szakszervezeti kirándulás résztvevői",
        "a sógor, aki Bécsből videómagnót hozott",
    ];

    public static readonly string[] Departments =
    [
        "BM III/III-2. osztály", "BM III/III-3. osztály", "BM III/III-4. osztály", "BM III/II. osztály", "BM III/I. csoportfőnökség",
    ];

    public static readonly string[] Categories =
    [
        "titkos megbízott", "ügynök", "titkos munkatárs", "informátor", "társadalmi kapcsolat",
    ];

    public static readonly string[] Bases =
    [
        "hazafias alapon",
        "anyagi érdekeltség alapján",
        "kompromittáló adatok alapján",
        "útlevélkérelme apropóján",
        "egy évek óta várt telefonbekötés reményében",
        "soron kívüli Trabant-kiutalás ígéretével",
    ];

    public static readonly string[] Rewards =
    [
        "300 Ft és egy doboz Fecske cigaretta",
        "kéthetes beutaló egy SZOT-üdülőbe",
        "Wartburg-kiutalás „mindössze” hat év várakozással",
        "két jegy a Táncdalfesztiválra",
        "egy doboz Sport szelet",
        "NDK-s utazás a Balaton helyett",
        "egy kiló banán karácsonyra",
        "egy pár nyugati farmer (használt)",
    ];

    public static readonly string[] GenericRemarks =
    [
        "Megbízható, de túl sokat beszél.",
        "Jelentéseit hibátlan helyesírással írja, ami önmagában gyanús.",
        "A találkozókra mindig pontosan érkezik, és mindig éhesen.",
        "Kávét nem kér, pogácsát igen.",
        "Ellenőrzése során semmi nem derült ki, ami maga is gyanús.",
        "A Szabad Európa Rádiót állítása szerint „csak a zene miatt” hallgatja.",
    ];

    public static readonly string[] HandlerSurnames =
    [
        "Kovács", "Tóth", "Nagy", "Horváth", "Varga", "Kiss", "Molnár", "Németh", "Farkas", "Balogh", "Papp", "Takács",
    ];

    public static readonly string[] HandlerRanks =
    [
        "r. hadnagy", "r. főhadnagy", "r. százados", "r. őrnagy", "r. alezredes",
    ];
}
