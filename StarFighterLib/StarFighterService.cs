namespace StarFighterLib;

public class StarFighterService : IStarFighterService
{
    public IList<StarFighter> BuildStarFighters(string parts)
    {
        IList<StarFighter> starFighters = new List<StarFighter>();
        List<char> partsList = parts.ToList();
        bool hasFighter = true;
        while (hasFighter)
        {
            if (HasFirstFighter(partsList))
            {
                starFighters.Add(new StarFighter());
                continue;
            }

            hasFighter = false;
        }

        return starFighters;
    }

    public IList<StarFighter> BuildBestStarFighters(string parts)
    {
        Dictionary<char, int> partCount = new()
        {
            { '(', 0 },
            { ')', 0 },
            { '-', 0 },
            { 'O', 0 },
            { '[', 0 },
            { ']', 0 },
        };

        foreach (char part in parts)
        {
            partCount[part]++;
        }

        int maxType2 = Math.Min(Math.Min(partCount['['], partCount[']']), Math.Min(partCount['-'] / 4, partCount['O']));

        List<StarFighter> bestStarFighters = new();
        for (int i = 0; i < maxType2; i++)
        {
            partCount['[']--;
            partCount[']']--;
            partCount['-'] -= 4;
            partCount['O']--;

            bestStarFighters.Add(new StarFighter(20));

            int maxType1 = Math.Min(Math.Min(partCount['('], partCount[')']), Math.Min(partCount['-'] / 2, partCount['O']));
            for (int j = 0; j < maxType1; j++)
            {
                partCount['(']--;
                partCount[')']--;
                partCount['-'] -= 2;
                partCount['O']--;
                bestStarFighters.Add(new StarFighter(15));
            }
        }

        return bestStarFighters;
    }

    private static bool HasFirstFighter(List<char> partsList)
        => partsList.Remove('(') &&
           partsList.Remove('-') &&
           partsList.Remove('O') &&
           partsList.Remove('-') &&
           partsList.Remove(')');
}
