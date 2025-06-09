namespace StarFighterLib.Components;

public class Wing : Component
{
    public Wing()
        : base(GetSerialNumber("WNG_"), '-')
    {
    }
}
