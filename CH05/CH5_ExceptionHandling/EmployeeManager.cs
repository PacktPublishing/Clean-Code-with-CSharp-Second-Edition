namespace CH5_ExceptionHandling;

public class EmployeeManager
{
    // Simulating a database operation
    public Employee GetEmployeeById(int employeeId)
    {
        // Assume this method might throw a database exception
        // if the employee with the given ID is not found.
        // Simulating a scenario where the employee is not found.
        throw new EmployeeNotFoundException($"Employee with ID { employeeId } not found");
    }
    // Simulating a file I/O operation
    public void SaveEmployeeToFile(Employee employee)
    {
        // Assume this method might throw a file I/O exception
        // if there is an issue writing to the file.
        // Simulating a scenario where the file cannot be written.
        throw new FileIOException("Error writing to the employee file");
    }
}
