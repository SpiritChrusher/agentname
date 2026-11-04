namespace AgentName.Generator;

public sealed record NvvhCase(
    string CaseName,
    string FileNo,
    string Subject,
    string Position,
    string Holdudvar,
    string Charge,
    string Method,
    string Period,
    string Amount,
    string SeizedAsset,
    string Investigator,
    string Stage,
    string ReferenceCase,
    string Note);

public static class NvvhCaseGenerator
{
    public static NvvhCase Generate(Inputs input, Random? random = null, NvvhCase? previous = null)
    {
        var rng = random ?? Random.Shared;
        var surname = input.Surname;

        var position = Array.Find(NvvhWords.Positions, p => p.Label == input.Position)
            ?? rng.Pick(NvvhWords.Positions);
        var holdudvar = Array.Find(NvvhWords.Holdudvars, h => h.Label == input.Holdudvar)
            ?? rng.Pick(NvvhWords.Holdudvars);
        var noHoldudvar = holdudvar.Label == NvvhWords.NoHoldudvar;

        string MakeCaseName()
        {
            var noun = surname is not null && rng.Chance(0.25) ? surname : rng.Pick(NvvhWords.CaseNouns);
            var (pattern, article) = rng.Pick(NvvhWords.CasePatterns);
            var name = string.Format(pattern, noun);
            return article ? Rng.WithArticle(name) : name;
        }

        var caseName = MakeCaseName();
        if (caseName == previous?.CaseName) caseName = MakeCaseName();

        var boost = holdudvar.Exponent > 0 ? holdudvar.Exponent : 0;
        var amount = rng.LogAmount(8 + boost, 10.8 + boost, 1_000_000);

        var asset = !noHoldudvar && rng.Chance(0.8)
            ? holdudvar.Asset
            : rng.Pick(NvvhWords.GenericAssets, previous?.SeizedAsset);

        return new NvvhCase(
            CaseName: caseName,
            FileNo: $"NVVH-2026/{rng.Next(1000, 10000)}",
            Subject: string.IsNullOrEmpty(input.Name?.Trim()) ? "N. N. (kitalált Fidesz-KDNP politikus)" : input.Name.Trim(),
            Position: $"{position.Label} · {position.Role}",
            Holdudvar: holdudvar.Label,
            Charge: rng.Pick(NvvhWords.Charges, previous?.Charge),
            Method: rng.Pick(NvvhWords.Methods, previous?.Method),
            Period: $"{rng.Next(2010, 2020)}–2026",
            Amount: Rng.FormatHuf(amount),
            SeizedAsset: asset,
            Investigator: $"{rng.Pick(NvvhWords.InvestigatorSurnames)} {rng.Pick(NvvhWords.InvestigatorRanks)}",
            Stage: rng.Pick(NvvhWords.Stages, previous?.Stage),
            ReferenceCase: rng.Pick(NerWords.ReferenceCases),
            Note: rng.Pick(NvvhWords.Notes, previous?.Note));
    }
}
