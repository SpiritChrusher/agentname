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
        "Hattyú", "Daru", "Kánya", "Ölyv", "Tengelic", "Vörösbegy", "Csíz", "Fürj", "Szalonka",
        // természet
        "Tavasz", "Szellő", "Nyárfa", "Akác", "Gesztenye", "Hóvirág", "Ibolya", "Tölgy", "Patak", "Szamóca",
        "Bodza", "Moha", "Zúzmara", "Hajnal", "Alkony", "Zivatar", "Platán", "Csalán",
        "Nádas", "Szil", "Juhar", "Rekettye", "Berek",
        // tárgyak
        "Hegedű", "Írógép", "Szifon", "Rádió", "Pipa", "Esernyő", "Kalap", "Ceruza", "Kulcscsomó",
        "Tranzisztor", "Lemezjátszó", "Svájcisapka", "Bőrönd", "Zsebkendő", "Diafilm", "Bakelit",
        "Kávédaráló", "Szódásüveg", "Kockacukor", "Gyufásdoboz", "Teáskanna", "Villanyborotva",
        "Vekker", "Magnetofon", "Varrógép", "Bicska", "Tükör", "Orsó", "Kalendárium", "Hangszóró",
        // foglalkozásszerű
        "Postás", "Mozigépész", "Kalauz", "Portás", "Hegedűs", "Kertész", "Asztalos", "Pék", "Sakkozó",
        "Vasutas", "Horgász", "Bélyeggyűjtő", "Villamosvezető", "Fodrász", "Kocsmáros", "Mozdonyvezető",
        // keresztnév-szerű
        "Pista", "Ferkó", "Jóska", "Marika", "Böske", "Lajcsi", "Gyurka", "Juliska", "Bandi", "Kati",
        "Erzsi", "Sanyi", "Pali", "Terka", "Ödön", "Béla",
        // egyéb
        "Bizalom", "Remény", "Kilátó", "Iránytű", "Visszhang", "Árnyék", "Ködös", "Délibáb", "Kristály",
        "Kacaj", "Titok", "Suttogás", "Örökség", "Vándor", "Mézeskalács", "Tücsök",
    ];

    public static readonly string[] Adjectives =
    [
        "Szürke", "Csendes", "Fürge", "Hallgatag", "Éber", "Ravasz", "Öreg", "Kis", "Vörös", "Fekete",
        "Szorgalmas", "Ködös", "Hűséges", "Álmos", "Kíváncsi", "Szerény", "Pontos", "Mosolygós",
        "Bajuszos", "Szemüveges", "Hajnali", "Éjféli", "Őszi", "Zöld",
        "Szeplős", "Pöttöm", "Nagyorrú", "Ráncos", "Fürkész", "Hegyes", "Suta", "Vakmerő",
        "Mélabús", "Lobogó", "Hétpróbás", "Kétes", "Reggeli", "Késői", "Viharos", "Kopasz",
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
        new("Kukori és Kotkoda", ["Kukori", "Kotkoda", "Kandúr"],
            "A szomszéd kakassal rendszeresen vitatkozik — a jegyzőkönyv szerint mindig ő kezdi."),
        new("A nagy ho-ho-horgász", ["Horgász", "Kukac", "Ponty"],
            "A halat nem fogta meg, a jelentést viszont igen. A kukacot tanúnak jelölte."),
        new("Pumukli", ["Pumukli", "Kobold", "Mester"],
            "A lakásban él, de papíron nincs bejelentve. A zsebeit rendszeresen átvizsgálják."),
        new("A kisvakond", ["Vakond", "Kisvakond", "Túrás"],
            "Föld alatti munkája miatt a lehallgatása technikailag nehézkes."),
        new("Tévémaci", ["Maci", "Tévémaci", "Pletyka"],
            "Minden este elköszön a nézőktől — ezt a jelentésben hazaárulásként értékelték."),
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
        new("Titkárnő", ["az igazgató naptára és a titkosított iratok", "a gépírók, akik nyugati újságokat is olvasnak"], "BM III/III-2. osztály"),
        new("Könyvtáros", ["a kölcsönzőpult, különösen a Nyugati folyóiratokat kérő olvasók", "a szabadpolc mögötti „zárt anyag”"], "BM III/III-3. osztály"),
        new("Villanyszerelő", ["a ház, ahol éjjel is ég a villany", "a szomszéd, aki maga szerezte be a nyugati kapcsolót"], "BM III/III-4. osztály"),
        new("Hentes", ["a húspult körül ácsorgók, különösen a „jó kapcsolatokkal” rendelkező vevők", "a belsőségek útja a hátsó ajtóig"], "BM III/III-4. osztály"),
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
        "{0}, a fürdő bejárata előtt, a jegyárusító ablak alatt",
        "{0}, a piac melletti presszóban, a sarokasztalnál",
        "{0}, a buszvégállomás várótermében, a menetrend mögött",
    ];

    public static readonly string[] GenericMeetingPlaces =
    [
        "az „Orgona” fedőnevű konspirációs lakás",
        "egy Balaton-parti SZOT-üdülő büféje",
        "egy zöld Trabant hátsó ülése",
        "a Népstadion B-szektora, félidőben",
        "a lakótelepi ABC tejpultja",
        "egy villamosmegálló, mindig a hatoson",
        "a megyei tanács fénymásoló-szobája, ebédszünetben",
        "egy presszó hátsó terme, a zenegép mellett",
        "a focipálya öltözője, félidőben",
        "egy téesz-iroda, ahol a naptár 1974-nél áll",
        "a vasutaslakótelep játszótere, a homokozó mellett",
        "az IBUSZ-iroda előtti sor, mindig ugyanaz a hely",
    ];

    public static readonly string[] GenericTargets =
    [
        "a lépcsőház lakói, különös tekintettel a 3. emeletre",
        "a szomszéd, aki gyanúsan sokat hallgatja a Szabad Európa Rádiót",
        "a szakszervezeti kirándulás résztvevői",
        "a sógor, aki Bécsből videómagnót hozott",
        "a fűtőház dolgozói, különösen az éjszakás műszak",
        "a templom körüli asszonyok, akik a legtöbbet tudják",
        "a gimnázium érettségiző osztálya, a szalagavató előtt",
        "a presszóban kártyázó nyugdíjasok asztaltársasága",
    ];

    public static readonly string[] Departments =
    [
        "BM III/III-2. osztály", "BM III/III-3. osztály", "BM III/III-4. osztály", "BM III/II. osztály", "BM III/I. csoportfőnökség",
        "BM III/III-5. osztály", "BM III/III-6. osztály", "BM III/II-3. osztály",
    ];

    public static readonly string[] Categories =
    [
        "titkos megbízott", "ügynök", "titkos munkatárs", "informátor", "társadalmi kapcsolat",
        "bizalmi személy", "rezidentúrai kapcsolat", "„társadalmi” informátor",
    ];

    public static readonly string[] Bases =
    [
        "hazafias alapon",
        "anyagi érdekeltség alapján",
        "kompromittáló adatok alapján",
        "útlevélkérelme apropóján",
        "egy évek óta várt telefonbekötés reményében",
        "soron kívüli Trabant-kiutalás ígéretével",
        "egy lakásigénylés kedvező elbírálása fejében",
        "egy SZOT-beutaló és egy üveg konyak ígéretével",
        "a fia egyetemi felvételének „támogatása” után",
        "egy belföldi útlevél megszerzésének reményében",
        "egy téesz-telefonkészülék beszerelése fejében",
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
        "egy üveg Tokaji Aszú, ládástul",
        "két kiló kávé és egy doboz gyümölcsös csokoládé",
        "heti egy kvarcóra-javítás „soron kívül”",
        "egy NDK-s varrógép, használtan",
        "egy télikabát és egy pár bőrkesztyű",
        "beutaló a szegedi gyógyfürdőbe, családi",
        "egy doboz szivarka a fiók alján",
    ];

    public static readonly string[] GenericRemarks =
    [
        "Megbízható, de túl sokat beszél.",
        "Jelentéseit hibátlan helyesírással írja, ami önmagában gyanús.",
        "A találkozókra mindig pontosan érkezik, és mindig éhesen.",
        "Kávét nem kér, pogácsát igen.",
        "Ellenőrzése során semmi nem derült ki, ami maga is gyanús.",
        "A Szabad Európa Rádiót állítása szerint „csak a zene miatt” hallgatja.",
        "A jelentéseit mindig pénteken adja le, hogy ne kelljen utána dolgozni.",
        "A találkozókon rendre késik, de hozza a süteményt.",
        "Túl lelkes. Ez a legnagyobb probléma vele.",
        "Szenvedélyesen gyűjt bélyeget — a nyugatiakat különösen.",
        "Az anyagai jól olvashatók, csaknem gyanúsan rendezettek.",
        "Azt állítja, hogy csak „hallgatózott”, soha nem jelentett.",
        "A fedőnevét két hét után elfelejtette, a sajátját nem.",
        "A villamoson túl hangosan beszél, ezért a találkozókat kocsiban tartják.",
    ];

    public static readonly string[] HandlerSurnames =
    [
        "Kovács", "Tóth", "Nagy", "Horváth", "Varga", "Kiss", "Molnár", "Németh", "Farkas", "Balogh", "Papp", "Takács",
        "Szabó", "Juhász", "Simon", "Fekete",
    ];

    public static readonly string[] HandlerRanks =
    [
        "r. hadnagy", "r. főhadnagy", "r. százados", "r. őrnagy", "r. alezredes", "r. ezredes", "r. alhadnagy",
    ];

    /// <summary>Dry, bureaucratic margin notes shown on the dossier.</summary>
    public static readonly string[] AdminNotes =
    [
        "A dosszié 8. oldala hiányzik — a fűtőtest mögött keresendő.",
        "A fénykép helyén cetli áll: „a fotó nem sikerült”.",
        "Az anyagot kétszer gépelték le; a második verzió rövidebb, de szebb.",
        "A fedőnév utólag tintával javítva. Az eredeti olvashatatlan.",
        "A 3. oldalon kávéfolt, a szöveg szerencsére olvasható maradt.",
        "A záradék keltezés nélkül maradt; a boríték postabélyegzője 1961.",
        "Az iratot 1989 novemberében valaki kivette, majd visszatette.",
        "A tartótiszt aláírása helyett egy macska mancslenyomata látható.",
        "A gépelési hiba javítása a margón: „nem elvtárs, kérem”.",
        "A dosszié fedőlapján a minősítés áthúzva, fölé írva: „még mindig”.",
        "Hiányzik a hátoldal; a tűzés nyomai alapján minimum két oldal volt.",
        "Az egyik jelentés dátuma későbbi, mint az utolsó bejegyzés.",
        "A név mögött zárójelben: „ha jól értettem”.",
        "Az anyaghoz tartozik egy selyempapírba csomagolt fényképnegatív.",
        "A dossziét kétszer zárták le, egyszer sem nyitották ki.",
        "A lapok sorszámozása 7 után 9-cel folytatódik.",
        "A cetli a borítón: „csak a főnöknek” — a főnök nem emlékszik rá.",
        "A jelentések végén rendre ott áll: „egyéb nem történt”.",
        "Az utolsó bejegyzés tollal: „áthelyezve más szervezeti egységhez”.",
        "A dossziéban egy focimeccs-jegy is lapul, 1978-ból.",
    ];
}
