# agentname — Mi lett volna az ügynökneved – és az ügyed?

What would've been your agent name in socialist Hungary — and your scandal afterwards? A small,
satirical generator written in Blazor WebAssembly (.NET 10), hosted on GitHub Pages.

Öt korszak, öt téma (fülek; link: `#kozepkor`, `#szocializmus`, `#rendszervaltas`, `#ner`, `#vagyonvisszaszerzes`):

| Korszak | Mit kapsz | Dizájn |
|---|---|---|
| 1000–1526, középkor | királyi ítélet vagy parasztlázadás krónikás bejegyzése | pergamen, viaszpecsét, iniciálé |
| 1957–1989, szocializmus (alapértelmezett) | fedőnév és „szigorúan titkos” dosszié | vörös csillag, írógépes akta |
| 1990–2010, rendszerváltás | privatizációs/szőkítéses ügy, fiktív cég, cégkivonat | teletext, CRT |
| 2010–2026, NER | közbeszerzés, nyertes ajánlattevő, túlárazás | kék plakát, hivatalos értesítő |
| 2026–, vagyonvisszaszerzés | NVVH-eljárás: vádpont, lefoglalt vagyon, jegyzőkönyv | NVVH-irat, piros pecsét |

Minden mező opcionális; a név és a korszak-specifikus választások fülváltáskor megmaradnak.
A középkori oldal saját vármegye- és szerepmezőt használ, a mai megye és foglalkozás ott nem jelenik meg.
Minden a böngészőben fut, semmi nem kerül elküldésre.

Szatíra: a neked generált fedőnév, ügy, cég és szereplők kitaláltak. A „mintaügyek” és az
eseménysávok közismert, nyilvános ügyekre utalnak (`Generator/TransitionWords.cs`,
`Generator/NerWords.cs` → `ReferenceCases`, `Events`); tényállításként nem értelmezendők.
Az NVVH, a 2026 utáni átmenet eseménysávja és a hozzá tartozó eljárások szintén fikciós szatírák;
valós személyhez nem rendelünk kitalált cselekményt. A középkori oldal generált ügyei kitaláltak;
a valós történelmi események „mintaeseményként” szerepelnek, az anakronisztikus büntetéseket a
szöveg jelöli.

## Run locally

```bash
dotnet run --project src/AgentName
```

## Size

No AOT on purpose: AOT makes Blazor WASM downloads bigger. Instead:

- full IL trimming, invariant globalization (no ICU data), most runtime feature switches off
  (see `src/AgentName/AgentName.csproj`);
- in CI the `wasm-tools` workload relinks `dotnet.native.wasm` with `-Oz` and the unused features removed;
- GitHub Pages can't serve pre-compressed files, so `index.html` hooks `loadBootResource` and fetches the
  `.br` (where the browser can decode Brotli natively) or `.gz` siblings, decompressing them with
  `DecompressionStream`.

| | `_framework` transfer |
|---|---|
| Template, untrimmed defaults, uncompressed | ~6.1 MB |
| This app, gzip via `loadBootResource` (local build, no relink) | ~2.7 MB |

The deploy workflow prints the exact sizes of each build in its job summary.

## Deploy

Push to `main`. One-time setup: **Settings → Pages → Source: GitHub Actions**.
Site: https://spiritchrusher.github.io/agentname/
