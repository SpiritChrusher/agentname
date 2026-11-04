namespace AgentName.Generator;

/// <summary>Word pools for the post-April-2026 era. The authority, cases and officials are fictional.</summary>
internal static class NvvhWords
{
    public sealed record Position(string Label, string Role);

    public static readonly Position[] Positions =
    [
        new("Választókerületi képviselő", "a helyi fejlesztések „gazdája”, pályázatíró nélkül"),
        new("Államtitkár", "a tárcaközi egyeztetés egyetlen résztvevője"),
        new("Megyei elnök", "a megyei közbeszerzések „összekötője”"),
        new("Önkormányzati képviselő", "a képviselő-testület egyhangú döntésének előkészítője"),
        new("Miniszteri biztos", "a kiemelt beruházás „gyorsításáért” felelős"),
        new("Állami cégvezető", "a vagyonkezelő igazgatóság elnöke, maga is vagyonkezelt"),
        new("Alapítványi kurátor", "a közérdekű vagyonkezelő alapítvány döntéshozója"),
        new("Szóvivő", "az ügy kommunikációjáért felelős, a dokumentumokat nem olvasta"),
    ];

    public sealed record Holdudvar(string Label, string Asset, double Exponent);

    public static readonly Holdudvar[] Holdudvars =
    [
        new("Polgármester sógor", "önkormányzati ingatlan jelképes bérleti díjjal", 0),
        new("Egykori osztálytárs", "balatoni nyaraló saját stéggel", 0.5),
        new("Média-tulajdonos", "regionális tévé és egy rádió", 0.6),
        new("Közbeszerzési tanácsadó", "iroda a Duna-parton, üvegfallal", 0.7),
        new("Alapítványi kurátor", "kastély alapítványi tulajdonban, örök időkre", 0.8),
        new("Vagyonkezelői kör", "saját tőkealap a szigeten", 0.9),
        new("Nincs senkim", "—", -1),
    ];

    public const string NoHoldudvar = "Nincs senkim";

    public static readonly string[] Charges =
    [
        "hűtlen kezelés",
        "költségvetési csalás",
        "vesztegetés elfogadása",
        "pénzmosás",
        "csalás",
        "sikkasztás",
        "befolyással üzérkedés",
        "nemzeti vagyon kezelésének elmulasztása",
    ];

    public static readonly string[] CaseNouns =
    [
        "Kastély", "Trafik", "Stadion", "Balatoni telek", "Kikötő", "Szélerőmű", "Napelempark",
        "Múzeumi sétány", "Hajóállomás", "Vadászház", "Szökőkút", "Kőpark", "Kilátó", "Kisvasút",
        "Bobpálya", "Tornacsarnok", "Uszoda", "Koncertterem", "Rendezvényközpont", "Golfpálya",
        "Lovarda", "Sípálya", "Csónakház", "Erdei iskola", "Parkolóház", "Múzeum", "Szoborpark",
        "Fürdő", "Kemping", "Tanyasi napelem",
    ];

    /// <summary>Pattern and whether it takes the definite article.</summary>
    public static readonly (string Pattern, bool Article)[] CasePatterns =
    [
        ("{0}-ügy", true),
        ("{0}-panama", true),
        ("A {0}-akták", false),
        ("Nagy {0}-átvétel", true),
        ("{0}-visszaszerzés", true),
        ("{0}-botrány", true),
        ("Nemzeti {0}-ügylet", true),
        ("{0}-per", true),
    ];

    public static readonly string[] FixedCaseNames =
    [
        "a Balatoni Telek, Amely Magától Épült",
        "a Kastély, Amely Visszakerült",
        "a Kilátó a Kilátóra",
        "a Trafik, a Sógor és a Pecsét",
        "a Stadion a Semmi Közepén",
        "a Napelempark Éjjel",
    ];

    public static readonly string[] Methods =
    [
        "közbeszerzés egyetlen, késve érkező ajánlattal",
        "szerződésmódosítás tizenegyszer, ugyanarra a napra keltezve",
        "uniós támogatásból épült, de a kulcs a magáncégé lett",
        "jelképes bérleti díj, valós haszon",
        "alvállalkozói lánc három szinten, minden szinten ugyanaz a cég",
        "800 oldalas tanulmány, 790 üres oldallal",
        "postafiók-cég vette meg a nyertes céget",
        "a vagyonkezelő kuratóriuma egy hét alatt döntött",
        "vissza nem térítendő támogatás, vissza nem térülő haszon",
        "a szerződést 2056-ig titkosították",
        "az értékelési szempont: „helyi kötődés”",
        "egyetlen ajánlat, három árajánlat ugyanattól a kéztől",
        "az ingatlant a cég alaptőkéjébe tették, értékbecslés nélkül",
        "a pályázat beadási határideje a nyertes megalakulása előtt járt le",
        "a tulajdonjog körbeért, a vagyon nem",
        "az önkormányzati döntés egyhangú volt, a jelenléti ív hiányzik",
        "a projekt költsége a duplájára nőtt, a haszon a felére",
        "közvetítő nélkül, közvetítői díjjal",
        "a vevő, az eladó és a tanácsadó ugyanaz a kör",
        "a szerződéshez csatolták a másik pályázat végét is",
    ];

    public static readonly string[] GenericAssets =
    [
        "balatoni nyaraló saját stéggel",
        "kastély, felújítva, bútorozva",
        "tokaji dűlő, pincével",
        "magánrepülő, „üzleti célra”",
        "régi autók gyűjteménye, zárt garázsban",
        "golfpálya melletti villa",
        "hotelrészesedés a Dunakanyarban",
        "traktorflotta, bérbe adva",
        "szőlőbirtok, uniós támogatással",
        "jacht az Adrián",
        "vadászház, saját leshellyel",
        "napelempark, a hálózatra kötve",
        "szélerőmű, papíron mezőgazdasági",
        "kikötőhely, harminc évre",
        "traktor és pótkocsi (a pótkocsi külön ügyben)",
        "műterem, panorámával",
        "raktár, ismeretlen tartalommal",
        "irodaház, üvegfallal, Duna-parton",
    ];

    public static readonly string[] Stages =
    [
        "vádemelés előkészítése",
        "vádalku, részleges vagyonvisszaszerzéssel",
        "az ügyet átadták az ügyészségnek",
        "a vagyon egy része külföldön van",
        "a gyanúsított tagad, a vagyon nem",
        "az eljárás felfüggesztve, amíg a cég felszámol",
        "vádemelés, a pecsét már megvan",
        "a nyomozás „újabb adatok” miatt meghosszabbítva",
        "a lefoglalást megtámadták, a nyaralót nem találták",
        "az első tárgyalás 2028-ra van kitűzve",
        "a kár megtérült — papíron",
        "a közvetítői megállapodás név nélkül maradt",
    ];

    public static readonly string[] InvestigatorSurnames =
    [
        "Kovács", "Tóth", "Nagy", "Horváth", "Varga", "Kiss", "Molnár", "Németh", "Farkas", "Balogh", "Papp", "Takács",
    ];

    public static readonly string[] InvestigatorRanks =
    [
        "NVVH nyomozó", "NVVH főnyomozó", "NVVH osztályvezető", "NVVH tanácsos", "NVVH vizsgáló",
    ];

    /// <summary>Dry, bureaucratic margin notes shown on the protocol.</summary>
    public static readonly string[] Notes =
    [
        "A jegyzőkönyv 3. oldalán a név helye üresen maradt.",
        "A lefoglalási jegyzékben a nyaraló „irodaként” szerepel.",
        "A szerződés két példánya között 4 oldal eltérés van.",
        "Az iratot a keltezés előtt három nappal iktatták.",
        "A pecsét alatt egy másik cég neve látszik.",
        "A gyanúsított nevét a jegyzőkönyvben kétszer elírták.",
        "A vagyonértékelést ugyanaz a cég végezte, amelyik a pályázatot is.",
        "A melléklet hiányzik, de a hiányzó mellékletre hivatkozik.",
        "Az eljárási határidő lejárt, az irat mégis „folyamatban”.",
        "A tanú nyilatkozata és a jegyzőkönyv szövege szó szerint egyezik — túlságosan is.",
        "A fénymásolaton a „titkos” pecsét olvashatóbb, mint a szöveg.",
        "A nyomozó aláírása helyett „láttam” felirat áll.",
        "A lefoglalt vagyon listáján szerepel egy cég, amely 2026 előtt megszűnt.",
        "Az ügyirat borítóján a régi hivatal neve át van húzva.",
        "A jegyzőkönyv szerint minden önkéntes volt, de három ajtó zárva.",
        "A pénz útja nyomon követhető — egészen a következő cégig.",
        "A szerződésmódosítás kelte megegyezik az eredeti szerződés keltezésével.",
        "A tanú idézete a sajtóban hosszabb, mint a jegyzőkönyvben.",
        "A lefoglalt iratok között egy bevásárlólista is van, tételszámokkal.",
        "A hivatali pecsét nedves volt, a keltezés elmosódott.",
    ];

    /// <summary>Fictional timeline of the post-election transition; satire only.</summary>
    public static readonly (string Year, string Label)[] Events =
    [
        ("2026. április", "Kormányváltás"),
        ("2026. május", "NVVH megalakulása"),
        ("2026. június", "Első vagyonvisszaszerzési eljárások"),
        ("2026. nyár", "Első lefoglalások"),
        ("2026. augusztus", "Vagyonárverési katalógus"),
        ("2026. ősz", "Első vádemelések"),
        ("2026. november", "„Rendszerváltás 2.0” bizottság"),
        ("2026. december", "Az első vádalku (zárt tárgyaláson)"),
    ];
}
