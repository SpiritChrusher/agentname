# agentname — Mi lett volna az ügynökneved – és az ügyed?

What would've been your agent name in socialist Hungary — and your scandal afterwards? A small,
satirical generator written in Blazor WebAssembly (.NET 10), hosted on GitHub Pages.

Három korszak, három téma (fülek; link: `#szocializmus`, `#rendszervaltas`, `#ner`):

| Korszak | Mit kapsz | Dizájn |
|---|---|---|
| 1957–1989, szocializmus (alapértelmezett) | fedőnév és „szigorúan titkos” dosszié | vörös csillag, írógépes akta |
| 1990–2010, rendszerváltás | privatizációs/szőkítéses ügy, fiktív cég, cégkivonat | teletext, CRT |
| 2010–2026, NER | közbeszerzés, nyertes ajánlattevő, túlárazás | kék plakát, hivatalos értesítő |

Minden mező opcionális, a közös adatok (név, év, megye, foglalkozás) megmaradnak fülváltáskor.
Minden a böngészőben fut, semmi nem kerül elküldésre.

Szatíra: a neked generált fedőnév, ügy, cég és szereplők kitaláltak. A „mintaügyek” és az
eseménysávok közismert, nyilvános ügyekre utalnak (`Generator/TransitionWords.cs`,
`Generator/NerWords.cs` → `ReferenceCases`, `Events`); tényállításként nem értelmezendők.

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
