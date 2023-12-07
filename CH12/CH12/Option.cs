namespace CH12;

public class Option<T>
{
    private readonly T value;

    public bool HasValue { get; }
    public T Value => HasValue ? value : throw new InvalidOperationException("Option has no value.");

    private Option() => HasValue = false;
    private Option(T value) { HasValue = true; this.value = value; }

    public static Option<T> Some(T value) => new Option<T>(value);
    public static Option<T> None() => new Option<T>();

    static void DoSomething()
    {
        Option<int> GetPositiveNumber(int num)
        {
            if (num > 0)
                return Option<int>.Some(num);
            else
                return Option<int>.None();
        }

        Option<int> result = GetPositiveNumber(-5);

        if (result.HasValue)
        {
            int value = result.Value;
            Console.WriteLine($"Positive number found: {value}");
        }
        else
        {
            Console.WriteLine("No positive number found.");
        }

    }
}
