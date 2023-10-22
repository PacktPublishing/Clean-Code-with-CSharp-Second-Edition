using CH09_AopWithPostSharp.Aspects;

namespace CH09_AopWithPostSharp;

internal class AopTestClass
{
    [LoggingAspect]
    public void SuccessfulMethod()
    {
        Console.WriteLine("Hello World, I am a success!");
    }

    [LoggingAspect]
    public void FailedMethod()
    {
        Console.WriteLine("Hello World, I am a failure!");
        var x = 1;
        var y = 0;
        var z = x / y;
    }
}
