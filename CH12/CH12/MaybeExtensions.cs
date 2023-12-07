namespace CH12;

public static class MaybeExtensions
{
    public static Maybe<T> ToMaybe<T>(this T value) => new Maybe<T>(value);
}
