namespace StarFighterLib.Components;

public class ComponentProvider : IComponentProvider
{
    public IComponent GetComponent(char componentType)
    {
        return componentType switch
        {
            '(' => new RoundWingTipStarboard(),
            ')' => new RoundWingTipPort(),
            '[' => new SquareWingTipStarboard(),
            ']' => new SquareWingTipPort(),
            '-' => new Wing(),
            'O' => new Cabin(),
            _ => new UnknownComponent()
        };
    }
}
