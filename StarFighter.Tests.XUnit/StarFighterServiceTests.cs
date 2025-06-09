using StarFighterLib;


namespace StarFighter.Tests.XUnit;

public class StarFighterServiceTests
{
    private readonly IStarFighterService _starFighterService = new StarFighterService();

    //Question1 - unit test for first example from README.md document
    /**
    * input: "(-O-)|&*-(-O-)(-O-)=+=.", result = 3  (3 already-complete star fighters)
    */
    [Fact]
    public void BuildStartFightersSample1()
    {
        var input = "(-O-)|&*-(-O-)(-O-)=+=.";
        var expectedCount = 3;
        var actual = _starFighterService.BuildStarFighters(input);

        Assert.Equal(expectedCount, actual.Count);
    }

    [Fact]
    public void BuildStartFightersSample2()
    {
        var input = "(-O-|)&*)-O-(";
        var expectedCount = 2;
        var actual = _starFighterService.BuildStarFighters(input);

        Assert.Equal(expectedCount, actual.Count);
    }


    // Question2 - unit test for first example from README.md document
    /**
    * input: "(-O-)[--O--]", result = 35 points  (1 x TYPE1, 1xTYPE2 )
    */
    [Fact]
    public void BuildBestStartFightersSample1()
    {
        var input = "(-O-)[--O--]";
        var expectedPoints = 35;
        var actual = _starFighterService.BuildBestStarFighters(input);

        Assert.Equal(expectedPoints, actual.Sum(x => x.Points));
    }

    // Question2 - unit test for second example from README.md document
    /**
    * input: "------((()))OOO[]", result = 45 points (3 x TYPE1)
    */
    [Fact]
    public void BuildBestStarFightersSample2()
    {
        var input = "------((()))OOO[]";
        var expectedPoints = 45;
        var actual = _starFighterService.BuildBestStarFighters(input);

        Assert.Equal(expectedPoints, actual.Sum(x => x.Points));
    }

    // Question2 - unit test for third example from README.md document
    /**
    * input: "((--O-[]", result = 0  (Not enough parts to even make one star figher of either kind)
    **/
    [Fact]
    public void BuildBestStarFightersSample3()
    {
        var input = "((--O-[]";
        var expectedPoints = 0;
        var actual = _starFighterService.BuildBestStarFighters(input);

        Assert.Equal(expectedPoints, actual.Sum(x => x.Points));
    }
}
