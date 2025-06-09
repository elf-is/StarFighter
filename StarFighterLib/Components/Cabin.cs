namespace StarFighterLib.Components;

public class Cabin : Component
{
    public Cabin()
        : base(GetSerialNumber("CAB_"), 'O')
    {
    }
}
