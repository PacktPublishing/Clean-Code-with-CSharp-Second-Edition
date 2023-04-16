using Serilog;

namespace CH5_ExceptionHandling;

public class LoggingExceptionHandler : IExceptionHandler
{
    private readonly ILogger _logger;

    public LoggingExceptionHandler(ILogger logger)
    {
        _logger = logger;
    }

    public bool HandleException(Exception ex)
    {
        _logger.Error(ex.ToString());
        return true;
    }
}

