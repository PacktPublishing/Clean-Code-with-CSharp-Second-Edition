namespace CH06_UnitTesting;

public interface IHttpClientWrapper
{
    Task<string> GetStringAsync(string requestUri);
}
