using Serilog;

namespace CH5_ExceptionHandling;

public class UnexpectedExceptionHandler : IExceptionHandler
{
    private ILogger _logger;

    public UnexpectedExceptionHandler(ILogger logger)
    {
        _logger = logger;
    }

    public bool HandleException(Exception ex)
    {
        _logger.Error($"Unexpected error: {ex.Message}");
        return true;
    }
}

