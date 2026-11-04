namespace AgentName.Generator;

public sealed record MedievalCase(
    string CaseName,
    string Entry,
    string Subject,
    string Mode,
    string Period,
    string Location,
    string Role,
    string AccusationTitle,
    string Accusation,
    string DetailTitle,
    string Detail,
    string OutcomeTitle,
    string Outcome,
    string ChroniclerNote,
    string ReferenceCase);

public static class MedievalCaseGenerator
{
    public static MedievalCase Generate(Inputs input, Random? random = null, MedievalCase? previous = null)
    {
        var rng = random ?? Random.Shared;
        var surname = input.Surname;
        var mode = Array.Find(MedievalWords.Modes, m => m.Label == input.MedievalMode)
            ?? rng.Pick(MedievalWords.Modes);
        var role = Array.Find(MedievalWords.Roles, r => r.Label == input.MedievalRole)
            ?? rng.Pick(MedievalWords.Roles);

        string MakeCaseName()
        {
            var noun = surname is not null && rng.Chance(0.25) ? surname : rng.Pick(MedievalWords.CaseNouns);
            var (pattern, article) = rng.Pick(MedievalWords.CasePatterns);
            var name = string.Format(pattern, noun);
            return article ? Rng.WithArticle(name) : name;
        }

        var caseName = MakeCaseName();
        if (caseName == previous?.CaseName) caseName = MakeCaseName();

        string accusation, detail, outcome;
        if (mode.Label == MedievalWords.RoyalMode)
        {
            accusation = rng.Pick(MedievalWords.RoyalAccusations, previous?.Accusation);
            detail = rng.Pick(MedievalWords.RoyalDetails, previous?.Detail);
            outcome = rng.Chance(0.18)
                ? rng.Pick(MedievalWords.AnachronisticVerdicts, previous?.Outcome)
                : rng.Pick(MedievalWords.RoyalVerdicts, previous?.Outcome);
        }
        else
        {
            accusation = rng.Pick(MedievalWords.RebellionGrievances, previous?.Accusation);
            detail = rng.Pick(MedievalWords.RebellionSlogans, previous?.Detail);
            outcome = rng.Pick(MedievalWords.RebellionOutcomes, previous?.Outcome);
        }

        var year = mode.Label == MedievalWords.RoyalMode ? rng.Next(1000, 1039) : 1514;
        var location = string.IsNullOrWhiteSpace(input.MedievalCounty)
            ? rng.Pick(MedievalWords.Counties)
            : input.MedievalCounty;
        var references = mode.Label == MedievalWords.RoyalMode
            ? MedievalWords.RoyalReferenceCases
            : MedievalWords.RebellionReferenceCases;
        var notes = mode.Label == MedievalWords.RoyalMode
            ? MedievalWords.RoyalNotes
            : MedievalWords.RebellionNotes;

        return new MedievalCase(
            CaseName: caseName,
            Entry: $"Anno Domini {Roman(year)} · Chronica Hungarorum, caput {Roman(rng.Next(1, 200))}",
            Subject: string.IsNullOrEmpty(input.Name?.Trim()) ? "N. N. (kitalált középkori alattvaló)" : input.Name.Trim(),
            Mode: mode.Label,
            Period: mode.Period,
            Location: location,
            Role: $"{role.Label} · {role.Detail}",
            AccusationTitle: mode.AccusationTitle,
            Accusation: accusation,
            DetailTitle: mode.DetailTitle,
            Detail: detail,
            OutcomeTitle: mode.OutcomeTitle,
            Outcome: outcome,
            ChroniclerNote: rng.Pick(notes, previous?.ChroniclerNote),
            ReferenceCase: rng.Pick(references, previous?.ReferenceCase));
    }

    private static string Roman(int value)
    {
        var map = new (int Value, string Symbol)[]
        {
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"), (100, "C"), (90, "XC"),
            (50, "L"), (40, "XL"), (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I"),
        };
        var sb = new System.Text.StringBuilder();
        foreach (var (v, symbol) in map)
        {
            while (value >= v)
            {
                sb.Append(symbol);
                value -= v;
            }
        }
        return sb.ToString();
    }
}
