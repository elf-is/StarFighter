namespace StarFighterLib.Components;

public interface IComponentProvider
{
    IComponent GetComponent(char componentType);
}
