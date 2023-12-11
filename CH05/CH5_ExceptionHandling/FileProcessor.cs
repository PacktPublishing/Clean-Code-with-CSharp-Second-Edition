using Serilog;
using System.Threading.Tasks;

namespace CH5_ExceptionHandling;

public class FileProcessor
{
    private ILogger _logger;
    private string _filePath;

    private readonly IEnumerable<IExceptionHandler> _exceptionHandlers;

    public FileProcessor(IEnumerable<IExceptionHandler> exceptionHandlers)
    {
        _exceptionHandlers = exceptionHandlers;
    }

    public FileProcessor(ILogger logger, string filePath)
    {
        _logger = logger;
        _filePath = filePath;
    }

    public string ReadFile()
    {
        if (!File.Exists(_filePath))
        {
            _logger.Error($"File {_filePath} does not exist.");
            return null;
        }

        try
        {
            using (StreamReader sr = new StreamReader(_filePath))
            {
                string content = sr.ReadToEnd();
                return content;
            }
        }
        catch (IOException ex)
        {
            _logger.Error($"An IO error occurred: {ex}");
            throw;
        }
        catch (Exception ex)
        {
            _logger.Error($"An error occurred: {ex}");
            throw;
        }
    }

    public void ProcessFile(string filePath)
    {
        try
        {
            // code that reads and processes the file
        }
        catch (FileNotFoundException ex)
        {
            _logger.Error($"File not found: {ex.FileName}");
            throw;
        }
        catch (IOException ex)
        {
            _logger.Error($"Error reading file: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            _logger.Error($"Unexpected error: {ex.Message}");
            throw;
        }
    }

    public void ProcessFile2(string filePath)
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

    public async Task DoSomething()
    {
        Task task1 = Task.Delay(100);
        Task task2 = Task.Delay(100);
        Task task3 = Task.Delay(100);

        try
        {
            await Task.WhenAll(task1, task2, task3);
        }
        catch (AggregateException ex)
        {
            // Handle or log the exceptions
            foreach (var innerException in ex.InnerExceptions)
            {
                // Handle or log each inner exception
            }
        }
        
        try
        {
            await Task.WhenAll(task1, task2, task3);
        }
        catch (AggregateException ex)
        {
            // Flatten the exception hierarchy
            var flattenedExceptions = ex.Flatten().InnerExceptions;
            // Handle or log the exceptions
            foreach (var innerException in flattenedExceptions)
            {
                // Handle or log each inner exception
            }
        }

        try
        {
            await Task.WhenAll(task1, task2, task3);
        }
        catch (AggregateException ex)
        {
            foreach (var innerException in ex.InnerExceptions)
            {
                if (innerException is SomeSpecificException)
                {
                    // Handle specific exception type
                }
                else
                {
                    // Handle or log other exceptions
                }
            }
        }
    }

    public async Task SomeAsyncMethod()
    {
        await Task.Delay(100);
    }

    public async Task AnotherAsyncMethod()
    {
        await Task.Delay(100);
    }

    public async Task DoSomethingElse()
    {
        var task1 = SomeAsyncMethod();
        var task2 = AnotherAsyncMethod();

        await Task.WhenAll(
            task1.ContinueWith(t => HandleTaskException(t)),
            task2.ContinueWith(t => HandleTaskException(t))
        );
    }

    void HandleTaskException(Task task)
    {
        if (task.Exception != null)
        {
            foreach (var innerException in task.Exception.InnerExceptions)
            {
                // Handle or log each inner exception
            }
        }
    }
}
