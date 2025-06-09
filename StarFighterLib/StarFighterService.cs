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
        => throw new NotImplementedException();

    private static bool HasFirstFighter(List<char> partsList)
        => partsList.Remove('(') &&
           partsList.Remove('-') &&
           partsList.Remove('O') &&
           partsList.Remove('-') &&
           partsList.Remove(')');
}
