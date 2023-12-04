using System;

namespace CH3.DependencyInjection;

internal class FileLogger : ILogger
{
    public void OutputMessage(string message)
    {
        // Implementation to log to a file (for simplicity, not implemented in this example) 
        Console.WriteLine($"File Logger: {message}");
    }
}