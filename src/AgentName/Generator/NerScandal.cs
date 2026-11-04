namespace AgentName.Generator;

public sealed record NerCase(
    string CaseName,
    string ProcNo,
    int Year,
    string Winner,
    string Subject,
    string Location,
    string Amount,
    int Overpricing,
    int EuShare,
    string Role,
    string Asset,
    string Outcome,
    string ReferenceCase,
    bool Outsider,
    string Note);

public static class NerScandal
{
    public static NerCase Generate(Inputs input, Random? random = null, NerCase? previous = null)
    {
        var rng = random ?? Random.Shared;
        var surname = input.Surname;
        var subject = rng.Pick(NerWords.Subjects);
        var connection = Array.Find(NerWords.Connections, c => c.Label == input.Connection);
        var outsider = connection?.Label == NerWords.NoConnection;

        string MakeCaseName()
        {
            if (rng.Chance(0.12)) return rng.Pick(NerWords.FixedCaseNames);

            var noun = surname is not null && rng.Chance(0.25) ? surname : subject.Noun;
            var (pattern, article) = rng.Pick(NerWords.CasePatterns);
            var name = string.Format(pattern, noun);
            return article ? Rng.WithArticle(name) : name;
        }

        string MakeWinner()
        {
            var name = surname is not null && !outsider
                ? $"{surname} és Társa"
                : $"{rng.Pick(NerWords.WinnerCores)} {rng.Pick(NerWords.WinnerKinds)}";
            return $"{name} {(rng.Chance(0.5) ? "Zrt." : "Kft.")}";
        }

        var caseName = MakeCaseName();
        if (caseName == previous?.CaseName) caseName = MakeCaseName();

        var winner = MakeWinner();
        if (winner == previous?.Winner) winner = MakeWinner();

        var location = input.Town ?? rng.Pick(WordLists.Counties).Town;

        var boost = connection is { Exponent: > 0 } ? connection.Exponent : 0;
        var amount = rng.LogAmount(8.3 + boost, 10.8 + boost, 1_000_000);

        var minYear = input.BirthYear is int by ? Math.Clamp(by + 18, 2010, 2026) : 2010;
        var year = rng.Next(minYear, 2027);

        string role, asset;
        if (outsider)
        {
            role = "adófizető — te fizeted a számlát";
            asset = "egy szép emlék a kilátóról";
        }
        else
        {
            role = NerWords.RolesByOccupation.TryGetValue(input.Occupation, out var r) && rng.Chance(0.8)
                ? r
                : rng.Pick(NerWords.GenericRoles);
            asset = connection is { Exponent: >= 0 } && rng.Chance(0.8) ? connection.Asset : rng.Pick(NerWords.GenericAssets);
        }

        return new NerCase(
            CaseName: caseName,
            ProcNo: $"{rng.Next(1000, 30000)}/{year}",
            Year: year,
            Winner: outsider ? $"{winner} (nem te)" : winner,
            Subject: subject.Description,
            Location: location,
            Amount: Rng.FormatHuf(amount),
            Overpricing: rng.Next(30, 401),
            EuShare: rng.Next(0, 19) * 5,
            Role: role,
            Asset: asset,
            Outcome: rng.Pick(NerWords.Outcomes, previous?.Outcome),
            ReferenceCase: rng.Pick(NerWords.ReferenceCases),
            Outsider: outsider,
            Note: rng.Pick(NerWords.Notes, previous?.Note));
    }
}
