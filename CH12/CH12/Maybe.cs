namespace CH12;

public class Maybe<T>
{
    private readonly T value;

    public bool HasValue { get; }
    public T Value => HasValue ? value : throw new InvalidOperationException("Maybe has no value.");

    private Maybe() => HasValue = false;
    public Maybe(T value) { HasValue = true; this.value = value; }
}