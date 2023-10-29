namespace CH3.Coupling.LowCohesion;

public class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int employeeId, decimal salary)
    {
        Name = name;
        EmployeeId = employeeId;
        Salary = salary;
    }

    public void CalculateTax()
    {
        // Tax calculation logic
        // ...
    }

    public void GeneratePayStub()
    {
        // Pay stub generation logic
        // ...
    }

    public void SaveToDatabase()
    {
        // Database save logic
        // ...
    }

    public void SendEmail()
    {
        // Email sending logic
        // ...
    }
}
