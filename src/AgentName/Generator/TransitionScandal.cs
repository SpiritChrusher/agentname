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
    string ReferenceCase,
    string Note);

public static class TransitionScandal
{
    public static TransitionCase Generate(Inputs input, Random? random = null, TransitionCase? previous = null)
    {
        var rng = random ?? Random.Shared;
        var surname = input.Surname;
        var car = Array.Find(TransitionWords.Cars, c => c.Label == input.FirstCar);

        string MakeCaseName()
        {
            var noun = surname is not null && rng.Chance(0.3) ? surname : rng.Pick(TransitionWords.CaseNouns);
            var (pattern, article) = rng.Pick(TransitionWords.CasePatterns);
            var name = string.Format(pattern, noun);
            return article ? Rng.WithArticle(name) : name;
        }

        string MakeCompany()
        {
            var prefix = surname ?? rng.Pick(TransitionWords.CaseNouns);
            return $"{prefix}-{rng.Pick(TransitionWords.CompanyCores)} {rng.Pick(TransitionWords.CompanyKinds)} {rng.Pick(TransitionWords.CompanyForms)}";
        }

        var caseName = MakeCaseName();
        if (caseName == previous?.CaseName) caseName = MakeCaseName();

        var company = MakeCompany();
        if (company == previous?.Company) company = MakeCompany();

        var minYear = input.BirthYear is int by ? Math.Clamp(by + 18, 1990, 2009) : 1990;
        var year = rng.Next(minYear, 2010);

        var role = TransitionWords.RolesByOccupation.TryGetValue(input.Occupation, out var r) && rng.Chance(0.8)
            ? r
            : rng.Pick(TransitionWords.GenericRoles);

        var luxury = car?.Luxury == true;
        var amount = rng.LogAmount(luxury ? 9 : 6.7, luxury ? 11 : 10.3, 100_000);

        var vehicle = car is not null && rng.Chance(0.85) ? car.Vehicle : rng.Pick(TransitionWords.GenericVehicles);
        var outcome = luxury && rng.Chance(0.7)
            ? rng.Pick(TransitionWords.LuxuryOutcomes, previous?.Outcome)
            : rng.Pick(TransitionWords.Outcomes, previous?.Outcome);

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
            Method: rng.Pick(TransitionWords.Methods, previous?.Method),
            Amount: Rng.FormatHuf(amount),
            Offshore: rng.Pick(TransitionWords.Offshores),
            Vehicle: vehicle,
            Outcome: outcome,
            ReferenceCase: rng.Pick(TransitionWords.ReferenceCases),
            Note: rng.Pick(TransitionWords.Notes, previous?.Note));
    }
}
