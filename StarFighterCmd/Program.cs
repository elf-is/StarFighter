using StarFighterLib;

var starFighterService = new StarFighterService();


Console.WriteLine("*****************************************************************");
Console.WriteLine("*                                                               *");
Console.WriteLine("*   ------            Star Fighter Service            ------    *");
Console.WriteLine("*                                                               *");
Console.WriteLine("*****************************************************************");
Console.WriteLine();
Console.WriteLine();

while (true)
{
    Console.Write("Enter component list or 'x' to exit>");
    var componentString = Console.ReadLine() ?? "";
    if (string.Equals(componentString, "x", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Exiting");
        return;
    }

    Console.WriteLine("Select option");
    Console.WriteLine("(1) Build basic only");
    Console.WriteLine("(2) Build best");

    var option = Console.ReadLine();

    var starFighters = option switch
    {
        "1" => starFighterService.BuildStarFighters(componentString),
        "2" => starFighterService.BuildBestStarFighters(componentString),
        _ => new List<StarFighter>(),
    };


    Console.WriteLine();
    Console.WriteLine($"Built {starFighters.Count} star fighter(s) totaling {starFighters.Sum(x => x.Points)} points.");

    Console.WriteLine();
}
