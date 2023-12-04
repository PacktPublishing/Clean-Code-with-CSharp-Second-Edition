namespace CH06_UnitTesting;

public class MyHttpClientFactory : IHttpClientFactory
{
    public HttpClient CreateClient()
    {
        return new HttpClient();
    }
}
