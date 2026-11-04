# Ügynöknév-generátor: kiindulási prompt és terv

## 1. Kiindulási prompt

> A small Blazor Webassembly .Net 10 client app onto Github pages (keep the binary file as small as possible with trimmings and/or AOT) for fun that can tell "Mi lett volna az ügynökneved a szocialista Magyarország alatt." Azért szeretném ezt az appot, mert ma kerültek nyilvánosságra az ügynökakták Magyarországon. A felhasználó kaphatna pár opcionális mezőt, név, életkor, kedvenc gyerekkori műsor, vagy valami, és random generálva lenne megjelenítve egy mező a generálás gomb megnyomása után. és valami látványos háttér legyen hozzá.
>
> Mit gondolsz?

## 2. Terv (jóváhagyva)

### Kontextus
Egy kis, szatirikus, statikus webapp: „Mi lett volna az ügynökneved a szocialista Magyarország alatt?”. Az opcionális mezőkből gombnyomásra fedőnév és dosszié generálódik látványos háttér előtt. Cél: minimális letöltési méret, GitHub Pages-en hosztolva.

### Egyeztetett döntések
- Minden gombnyomásra új név (nem determinisztikus).
- Szatirikus, könnyed hangvétel, amely nem gúnyolja az áldozatokat.
- Csak trimming, AOT nélkül (Blazor WASM-nál az AOT nagyobb letöltést ad).

### Méretstratégia
- `PublishTrimmed`, `TrimMode=full`, `InvariantGlobalization`, több runtime-feature kikapcsolása.
- CI-ban `wasm-tools` workload és natív relinkelés (`-Oz`).
- A GitHub Pages nem szolgál ki tömörített fájlt, ezért az `index.html` `loadBootResource` hookja a `.br` vagy `.gz` változatot tölti le, és a böngésző bontja ki.
- Mért eredmény: a `_framework` letöltése kb. 6,1 MB-ról kb. 2,7 MB-ra csökkent.

### Felépítés
- `src/AgentName/` (Blazor WASM, net10.0): `App.razor`, `Program.cs`, `_Imports.razor`, `AgentName.csproj`.
- `src/AgentName/Generator/`: `CodeNameGenerator.cs` (generátor), `WordLists.cs` (szólisták).
- `src/AgentName/wwwroot/`: `index.html` (betöltő), `css/app.css` (háttér, dosszié-stílus).
- `.github/workflows/deploy.yml`: build, méretösszesítő, deploy GitHub Pages-re.
- `README.md`, `.gitignore`.

### Funkció
- Opcionális mezők: név, születési év, megye, foglalkozás, kedvenc gyerekkori műsor.
- Generált tartalom: fedőnév, iktatószám, minősítés, beszervezés éve és módja, tartótiszt, találkozóhely, célszemély, jelentések száma, jutalom, értékelés.
- A mezők súlyozzák a szólistákat (név kezdőbetű, műsor-specifikus szavak, foglalkozáshoz tartozó célpont, megyeszékhely).
- Nem használ valós személyeket vagy valós fedőneveket.

### Háttér és megjelenítés
- Csak CSS: forgó vörös sugarak, izzó csillag, filmszemcse.
- Papírlap gemkapoccsal, „Szigorúan titkos!” pecsét, begépelődő fedőnév.
- `prefers-reduced-motion` támogatás, mobilbarát elrendezés (16px gutter, nincs vízszintes görgetés).

### Ellenőrzés
1. `dotnet publish` mérése (raw, gzip, brotli).
2. Helyi kiszolgálás a publish kimenetből, `/agentname/` alútvonallal: űrlap, generálás, másolás, mobil nézet, konzol.
3. `dotnet run` fejlesztői módban is.
4. Commit és push csak jóváhagyás után.

## 3. Második kérés: három korszak

> Legyen 3 része az appnak, 3 oldal vagy 4 tab: az első megvan, a szocializmus alatti. Aztán kellene egy a rendszerváltástól a 2010ig tartó időszaknak 1, a spontán privatizációs, olajszőkítés, Öszödi beszéd rendőrattack, 4es metró, stb. A 3. oldal pedig a NER korszaka lenne 2010es fülkeforradalomtól a 2026os kormányváltásig.
>
> És az emberek a különböző csalások neveit kaphatnák meg a beírt adataik alapján (vagy full random, mert a mezők itt is opcionálisak legyenek) ennél a 2 új oldalnál. Tematikus dizájn legyen itt is, és gondold át, hogy a 3 oldal közti váltás hogyan lehetne a legjobb. Szerintem maradjon alapértemezettként a szocialista rész.

## 4. Terv a három korszakhoz (jóváhagyva)

### Egyeztetett döntések
- A rendszerváltás oldal Teletext/CRT dizájnt kap.
- Közismert valós ügynevek szerepelhetnek „mintaügyként”, személynévvel is. Csak az ügy nevét és tárgyát írjuk le; valós személyt nem kötünk kitalált tetthez.

### Váltás a korszakok között
- Sticky „időgép” fülsáv: `1957–1989` / `1990–2010` / `2010–2026`, alatta Szocializmus / Rendszerváltás / NER.
- URL hash: `#szocializmus` (alapértelmezett), `#rendszervaltas`, `#ner`. Megosztható, működik a vissza gomb, GitHub Pages-en nem kell 404-trükk.
- A gyökérelemen `data-era`; mindhárom háttér a DOM-ban van, a váltás keresztáttűnés.
- A beírt név, év, megye, foglalkozás közös; fülváltáskor megmarad. Korszakonként külön eredmény.
- ←/→ nyilak váltanak a fülek között.

### Rendszerváltás (1990–2010)
- Dizájn: teletext oldal (VT323 font, színsávok, mozaik, CRT-csíkok, futó árfolyamszalag).
- Eredmény: fénymásolt cégkivonat kék „HATÁLYTALANÍTVA” pecséttel: ügynév, fiktív cég, szerep, év, módszer, elszívott összeg, offshore, szállítóeszköz, kimenetel, mintaügy.
- Extra mező: „Első autód” (a BMW/Mercedes többnyire felmentést hoz).
- Eseménysáv: taxisblokád, kárpótlás, spontán privatizáció, olajszőkítés, Bokros-csomag, Tocsik, Postabank, K&H, Őszöd és a rendőri fellépés, válság, BKV, 4-es metró.

### NER (2010–2026)
- Dizájn: kék plakát (sárga kiemelés), EU-csillagkör, nemzeti szalag, úszó szlogenek, stadion-sziluett.
- Eredmény: közbeszerzési eredményhirdetés arany „NYERTES” pecséttel: projektnév, nyertes, 1 db ajánlat, tárgy, érték, túlárazás, uniós forrás, szerep, „ebből lett”, kimenetel, mintaügy.
- Extra mező: „Kapcsolati tőke” (a „Nincs senkim” esetén te fizeted a számlát).
- Eseménysáv: kétharmad, Alaptörvény, letelepedési kötvény, trafik, stadionok, kerítés, MNB- és KEKVA-alapítványok, Pegasus, kék plakátok, kormányváltás.

### Kód
- `Generator/Inputs.cs`, `Rng.cs` (közös segédek), `TransitionWords.cs` + `TransitionScandal.cs`, `NerWords.cs` + `NerScandal.cs`.
- A valós ügylista egy helyen: `TransitionWords.ReferenceCases` / `Events`, `NerWords.ReferenceCases` / `Events`.
- `Eras/` (Era, SocialistEra, TransitionEra, NerEra), `Components/` (EraTabs, CommonFields, CopyButton, EventStrip).
- Nincs új csomag, nincs Router.

## 5. Állapot a fájl frissítésekor
- Mindhárom korszak működik helyben: fülváltás, közös mezők, hash-link, vissza gomb, generálás, mobil nézet (nincs vízszintes görgetés), hibamentes konzol.
- Méret: a gzip `_framework` kb. 2,49 MB-ról 2,51 MB-ra nőtt (+20 KB).
- A dev szerveres betöltési hiba (dupla dekompresszió) javítva.
- Nincs commit. A push és a GitHub Pages beállítás (Settings → Pages → Source: GitHub Actions) még hátravan; a CI-s `wasm-tools` relinkelés még nem futott le.

## 6. Negyedik korszak: NVVH (2026–)

### Kérés és döntések
- 2026. áprilisi kormányváltás utáni oldal: Fidesz-KDNP politikusként milyen ügy miatt vinne el az NVVH.
- Extra mezők: „Pozíció 2010–2026” és „Holdudvar / kapcsolat”.
- Dizájn: NVVH eljárási jegyzőkönyv, fehér irat, piros „LEFOGLALVA” pecsét, redakciós háttér.
- Fül: `2026–` / `Vagyonvisszaszerzés`; hash: `#vagyonvisszaszerzes`; `data-era=nvvh`.

### Kód
- `Generator/NvvhWords.cs` + `NvvhCaseGenerator.cs` (ügynév, vádpont, ügylet, összeg, lefoglalt vagyon, nyomozó, eljárási szakasz, megjegyzés).
- `Eras/NvvhEra.razor`; `Era.cs`, `EraTabs.razor` (4 elemű refs/modulo), `App.razor` (bg-nvvh), `Inputs.cs` (Position, Holdudvar), `app.css`.
- Mintaügyek: a meglévő `NerWords.ReferenceCases` újrahasználva, új valós tényállítás nélkül.
- Anti-repeat: `previous` + `Rng.Pick(..., avoid)`, mint a többi korszakban.

### Biztonsági keret
- Nincs valós személynév a generált ügyekben; a hivatal, a vádlott-szerep és az eseménysáv fikció.
- Valós ügyek csak közismert, nyilvános „mintaügy” névvel/tárggyal; nincs Btk.-paragrafus és nincs valós cég-/ügyszám.
- Footer + README disclaimer jelzi, hogy valós személyhez nem rendelünk kitalált cselekményt.

## 7. Ötödik korszak: Középkor (1000–1526)

### Kérés és döntések
- Egy új, időrendben első oldal két móddal: „Királyi ítélet” (Szent István kora) és „Parasztlázadás” (Dózsa kora).
- Extra mezők: „Ügy típusa” és „Szereped”; a közös mezők megmaradnak fülváltáskor.
- Középkori űrlap: Név, Vármegye, Ügy típusa, Szereped; a modern megye/foglalkozás és a születési év nem jelenik meg (a foglalkozást a szerep váltja ki).
- Dizájn: pergamen, viaszpecsét, iniciálé, krónikás hangvétel; középkori helyesírású nevek (Anno Domini, Chronica, caput, latin ügynév-tövek).
- A felnégyelés csak a lázadás-módban korszakos; a királyi módban jelölt anakronizmus.

### Kód
- `Generator/MedievalWords.cs` + `MedievalCaseGenerator.cs`; `Eras/KozepkorEra.razor`.
- `Era.cs` (Kozepkor), `EraTabs.razor` (5 fül + automatikus oldalgörgetés), `App.razor` (bg-med), `Inputs.cs`, `app.css`.
- Mobilon a fülsáv vízszintesen görgethető; az aktív fül `scrollIntoView`-val középre kerül.

### Biztonsági keret
- A user a kitalált vádlott; valós személyhez nincs kitalált bűn.
- Valós események (Szent István törvényei, Vata-felkelés, Aranybulla, tatárjárás, Dózsa 1514, Mohács 1526) csak mintaeseményként.
- Nincs etnikai/vallási csoportot célzó vád; az anakronizmus és a szatíra jelölve.
