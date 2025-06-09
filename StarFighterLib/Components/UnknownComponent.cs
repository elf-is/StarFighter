namespace StarFighterLib.Components;

public class UnknownComponent : Component
{
    public UnknownComponent()
        : base(GetSerialNumber("XXX_"), 'O')
    {
    }
}
