namespace CH3.ImmutableObjectsAndDataStructures;

public class ImmutableClass
{
    private readonly int _value;

    public ImmutableClass(int value)
    {
        _value = value;
    }
    public int Value => _value;
    public ImmutableClass Add(int value)
    {
        return new ImmutableClass(_value + value);
    }
}