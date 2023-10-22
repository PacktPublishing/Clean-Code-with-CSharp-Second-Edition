using CrossCuttingConcerns.Caching;
using CrossCuttingConcerns.Instrumentation;

namespace TestHarness;

public class TestClass
{
    [InstrumentationAspect]
    public string GetCachedItem()
    {
        return MemoryCache.GetItem<string>("Message", TimeSpan.FromSeconds(30), GetMessage);
    }
    private string GetMessage()
    {
        return "Hello, world of cache!";
    }

}
