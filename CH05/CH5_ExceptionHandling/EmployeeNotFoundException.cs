namespace CH5_ExceptionHandling;

public class EmployeeNotFoundException : Exception
{
    public EmployeeNotFoundException(string message) : base(message)
    {
    }
}
