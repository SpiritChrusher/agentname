namespace AgentName.Generator;

public sealed record TransitionCase(
    string CaseName,
    string Company,
    string CourtNo,
    string Court,
    int Year,
    string Role,
    string Method,
    string Amount,
    string Offshore,
    string Vehicle,
    string Outcome,
    string ReferenceCase);

public static class TransitionScandal
{
    public static TransitionCase Generate(Inputs input, Random? random = null)
    {
        var rng = random ?? Random.Shared;
        var surname = input.Surname;
        var car = Array.Find(TransitionWords.Cars, c => c.Label == input.FirstCar);

        var noun = surname is not null && rng.Chance(0.3) ? surname : rng.Pick(TransitionWords.CaseNouns);
        var (pattern, article) = rng.Pick(TransitionWords.CasePatterns);
        var caseName = string.Format(pattern, noun);
        if (article) caseName = Rng.WithArticle(caseName);

        var prefix = surname ?? rng.Pick(TransitionWords.CaseNouns);
        var company = $"{prefix}-{rng.Pick(TransitionWords.CompanyCores)} {rng.Pick(TransitionWords.CompanyKinds)} {rng.Pick(TransitionWords.CompanyForms)}";

        var minYear = input.BirthYear is int by ? Math.Clamp(by + 18, 1990, 2009) : 1990;
        var year = rng.Next(minYear, 2010);

        var role = TransitionWords.RolesByOccupation.TryGetValue(input.Occupation, out var r) && rng.Chance(0.8)
            ? r
            : rng.Pick(TransitionWords.GenericRoles);

        var luxury = car?.Luxury == true;
        var amount = rng.LogAmount(luxury ? 9 : 6.7, luxury ? 11 : 10.3, 100_000);

        var vehicle = car is not null && rng.Chance(0.85) ? car.Vehicle : rng.Pick(TransitionWords.GenericVehicles);
        var outcome = luxury && rng.Chance(0.7) ? rng.Pick(TransitionWords.LuxuryOutcomes) : rng.Pick(TransitionWords.Outcomes);

        var town = input.Town;
        var court = town is null || town == "Budapest"
            ? "Fővárosi Bíróság mint Cégbíróság"
            : $"{input.County} Megyei Bíróság mint Cégbíróság";

        return new TransitionCase(
            CaseName: caseName,
            Company: company,
            CourtNo: $"Cg. {rng.Next(1, 20):00}-{rng.Next(2) + 9:00}-{rng.Next(100000, 1000000)}",
            Court: court,
            Year: year,
            Role: role,
            Method: rng.Pick(TransitionWords.Methods),
            Amount: Rng.FormatHuf(amount),
            Offshore: rng.Pick(TransitionWords.Offshores),
            Vehicle: vehicle,
            Outcome: outcome,
            ReferenceCase: rng.Pick(TransitionWords.ReferenceCases));
    }
}
