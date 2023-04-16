using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5_ExceptionHandling;

public class IOExceptionHandler : IExceptionHandler
{
    private ILogger _logger;

    public IOExceptionHandler(ILogger logger)
    {
        _logger = logger;
    }

    public bool HandleException(Exception ex)
    {
        if (ex is IOException)
        {
            _logger.Error($"Error reading file: {ex.Message}");
            return true;
        }

        return false;
    }
}

