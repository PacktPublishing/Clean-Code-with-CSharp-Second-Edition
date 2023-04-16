using Serilog;

namespace CH5_ExceptionHandling;

public interface IExceptionHandler
{
    bool HandleException(Exception ex);
}
