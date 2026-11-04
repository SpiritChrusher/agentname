namespace AgentName.Generator;

public sealed record Dossier(
    string Subject,
    string CodeName,
    string FileNumber,
    string Department,
    string Category,
    string RecruitYear,
    string Basis,
    string Handler,
    string MeetingPlace,
    string Target,
    int Reports,
    string Remark,
    string Reward,
    string Note);

public static class CodeNameGenerator
{
    private const int FirstYear = 1957;
    private const int LastYear = 1989;

    public static Dossier Generate(Inputs input, Random? random = null, Dossier? previous = null)
    {
        var rng = random ?? Random.Shared;
        var name = input.Name?.Trim();
        var show = Array.Find(WordLists.Shows, s => s.Label == input.Show);
        var occupation = Array.Find(WordLists.Occupations, o => o.Label == input.Occupation);
        var town = input.Town;

        var codeName = MakeCodeName(rng, name, show);
        if (codeName == previous?.CodeName) codeName = MakeCodeName(rng, name, show);

        var birthYear = input.BirthYear is >= 1900 and <= 2030 ? input.BirthYear : null;
        string recruitYear, category, basis;
        int reports;
        if (birthYear is int by && by + 16 > LastYear)
        {
            // Too young to be recruited before 1989.
            recruitYear = by > LastYear ? "—" : "nem szervezhető be (még)";
            category = by > LastYear ? "rendszerváltás utáni születés" : "megfigyelt kisdobos";
            basis = by > LastYear
                ? "a dosszié ennek ellenére létezik, csak még nem tud róla"
                : "az őrsvezető így is jelentett róla — kétszer";
            reports = 0;
        }
        else
        {
            var from = Math.Max(FirstYear, (birthYear ?? 1930) + 18);
            var year = from > LastYear ? LastYear : rng.Next(from, LastYear + 1);
            recruitYear = year.ToString();
            category = Pick(rng, WordLists.Categories);
            basis = Pick(rng, WordLists.Bases);
            reports = (int)Math.Round(Math.Pow(rng.NextDouble(), 2) * (LastYear - year + 1) * 24) + 1;
        }

        var meeting = town is not null && rng.NextDouble() < 0.75
            ? string.Format(Pick(rng, WordLists.TownMeetingPlaces), town)
            : Pick(rng, WordLists.GenericMeetingPlaces);

        var target = occupation is not null && rng.NextDouble() < 0.8
            ? Pick(rng, occupation.Targets)
            : Pick(rng, WordLists.GenericTargets);

        var department = occupation?.Department ?? Pick(rng, WordLists.Departments);

        var remark = show is not null && rng.NextDouble() < 0.7
            ? show.Remark
            : rng.Pick(WordLists.GenericRemarks, previous?.Remark);

        var handler = $"{Pick(rng, WordLists.HandlerSurnames)} {Pick(rng, WordLists.HandlerRanks)}";
        var fileNumber = $"{(rng.Next(2) == 0 ? "M" : "B")}-{rng.Next(10000, 100000)}";

        return new Dossier(
            Subject: string.IsNullOrEmpty(name) ? "N. N. (ismeretlen elvtárs)" : name,
            CodeName: codeName,
            FileNumber: fileNumber,
            Department: department,
            Category: category,
            RecruitYear: recruitYear,
            Basis: basis,
            Handler: handler,
            MeetingPlace: meeting,
            Target: target,
            Reports: reports,
            Remark: remark,
            Reward: rng.Pick(WordLists.Rewards, previous?.Reward),
            Note: rng.Pick(WordLists.AdminNotes, previous?.Note));
    }

    private static string MakeCodeName(Random rng, string? name, WordLists.Show? show)
    {
        string noun;
        if (show is { Nouns.Length: > 0 } && rng.NextDouble() < 0.35)
        {
            noun = Pick(rng, show.Nouns);
        }
        else
        {
            noun = Pick(rng, WordLists.Nouns);
            // Alliterate with the given name half the time: "Kristóf" -> "Kalap".
            if (!string.IsNullOrEmpty(name) && rng.NextDouble() < 0.5)
            {
                var initial = char.ToUpperInvariant(name[0]);
                var matches = Array.FindAll(WordLists.Nouns, n => n[0] == initial);
                if (matches.Length > 0) noun = Pick(rng, matches);
            }
        }

        return rng.NextDouble() < 0.3 ? $"{Pick(rng, WordLists.Adjectives)} {noun}" : noun;
    }

    private static T Pick<T>(Random rng, T[] items) => rng.Pick(items);
}
