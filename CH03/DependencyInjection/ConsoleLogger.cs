using System;

namespace CH3.DependencyInjection;

internal class ConsoleLogger : ILogger
{
    public void OutputMessage(string message)
    {
        Console.WriteLine(message);
    }
}
