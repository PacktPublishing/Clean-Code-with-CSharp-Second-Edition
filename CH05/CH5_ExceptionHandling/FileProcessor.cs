using Serilog;

namespace CH5_ExceptionHandling;

//public class FileProcessor
//{
//    private ILogger _logger;

//    public FileProcessor(ILogger logger)
//    {
//        _logger = logger;
//    }

//    public void ProcessFile(string filePath)
//    {
//        try
//        {
//            // code that reads and processes the file
//        }
//        catch (FileNotFoundException ex)
//        {
//            _logger.Error($"File not found: {ex.FileName}");
//            throw;
//        }
//        catch (IOException ex)
//        {
//            _logger.Error($"Error reading file: {ex.Message}");
//            throw;
//        }
//        catch (Exception ex)
//        {
//            _logger.Error($"Unexpected error: {ex.Message}");
//            throw;
//        }
//    }
//}

public class FileProcessor
{
    private readonly IEnumerable<IExceptionHandler> _exceptionHandlers;

    public FileProcessor(IEnumerable<IExceptionHandler> exceptionHandlers)
    {
        _exceptionHandlers = exceptionHandlers;
    }

    public void ProcessFile(string filePath)
    {
        try
        {
            // code that reads and processes the file
        }
        catch (Exception ex)
        {
            var handled = false;
            foreach (var handler in _exceptionHandlers)
            {
                if (handler.HandleException(ex))
                {
                    handled = true;
                    break;
                }
            }

            if (!handled)
            {
                throw;
            }
        }
    }
}
