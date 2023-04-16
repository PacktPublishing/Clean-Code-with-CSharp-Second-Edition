using Serilog;

namespace CH5_ExceptionHandling;

public class FileNotFoundExceptionHandler : IExceptionHandler
{
    private ILogger _logger;

    public FileNotFoundExceptionHandler(ILogger logger)
    {
        _logger = logger;
    }

    public bool HandleException(Exception ex)
    {
        if (ex is FileNotFoundException)
        {
            _logger.Error($"File not found: {((FileNotFoundException)ex).FileName}");
            return true;
        }

        return false;
    }
}
