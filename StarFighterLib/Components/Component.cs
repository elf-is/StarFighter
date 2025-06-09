using System.Diagnostics;

namespace StarFighterLib.Components;

[DebuggerDisplay("{Type}")]
public abstract class Component : IComponent, IEquatable<Component>
{
    public char Type { get; }
    public string SerialNumber { get; }

    protected Component(string serialNumber, char componentType)
    {
        SerialNumber = serialNumber;
        Type = componentType;
    }

    public bool Equals(Component? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Type == other.Type;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((Component)obj);
    }

    public override int GetHashCode() =>
        Type.GetHashCode();

    public static bool operator ==(Component? left, Component? right) =>
        Equals(left, right);

    public static bool operator !=(Component? left, Component? right) =>
        !Equals(left, right);

    private static int _counter = 0;

    protected static string GetSerialNumber(string prefix) =>
        $"{prefix}{_counter++:0000}";
}
