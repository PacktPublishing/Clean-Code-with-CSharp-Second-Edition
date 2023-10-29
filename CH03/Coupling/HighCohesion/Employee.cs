namespace CH3.Coupling.HighCohesion;

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
}