namespace StarFighterLib;

public interface IStarFighterService
{
    IList<StarFighter> BuildStarFighters(string data);
    IList<StarFighter> BuildBestStarFighters(string data);
}
