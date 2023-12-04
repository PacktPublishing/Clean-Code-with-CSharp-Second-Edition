using System.Runtime.CompilerServices;

namespace CH06_UnitTesting;

public class MyHttpClientWrapper : IHttpClientWrapper
{
    private readonly HttpClient _httpClient;    

    public MyHttpClientWrapper(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetStringAsync(string requestUri)
    {
        return await _httpClient.GetStringAsync(requestUri);    
    }
}
