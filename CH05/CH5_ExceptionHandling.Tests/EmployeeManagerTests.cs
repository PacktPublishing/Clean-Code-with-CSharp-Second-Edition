using Moq;
using System;

namespace CH5_ExceptionHandling.Tests;

[TestFixture]
internal class EmployeeManagerTests
{
    [Test]
    public void GetEmployeeById_EmployeeFound_ReturnsEmployee()
    {
        // Arrange
        int employeeId = 1;
        Employee expectedEmployee = new Employee
        {
            EmployeeId = employeeId,
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateTime(1990, 1, 1)
        };
        var mockEmployeeManager = new Mock<EmployeeManager>();
        mockEmployeeManager.Setup(manager => manager.GetEmployeeById(employeeId)).Returns(expectedEmployee);

        // Act
        Employee actualEmployee = mockEmployeeManager.Object.GetEmployeeById(employeeId);

        // Assert
        Assert.AreEqual(expectedEmployee, actualEmployee);
    }

    [Test]
    public void GetEmployeeById_EmployeeNotFound_ThrowsEmployeeNotFoundException()
    {
        // Arrange
        int employeeId = 1;
        var mockEmployeeManager = new Mock<EmployeeManager>();
        mockEmployeeManager.Setup(manager => manager.GetEmployeeById(employeeId)).Throws(new EmployeeNotFoundException("Employee not found"));

        // Act and Assert
        Assert.Throws<EmployeeNotFoundException>(() =>
        mockEmployeeManager.Object.GetEmployeeById(employeeId));
    }

    [Test]
    public void SaveEmployeeToFile_SuccessfulSave_NoExceptionThrown()
    {
        // Arrange
        var employee = new Employee
        {
            EmployeeId = 2,
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateTime(1990, 1, 1)
        };
        var mockEmployeeManager = new Mock<EmployeeManager>();
        mockEmployeeManager.Setup(manager => manager.SaveEmployeeToFile(employee));

        // Act and Assert (no exception should be thrown)
        Assert.DoesNotThrow(() => mockEmployeeManager.Object.SaveEmployeeToFile(employee));
    }

    [Test]
    public void SaveEmployeeToFile_FileIOExceptionThrown_CatchesException()
    {
        // Arrange
        var employee = new Employee
        {
            EmployeeId = 2,
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateTime(1990, 1, 1)
        };
        var mockEmployeeManager = new Mock<EmployeeManager>();
        mockEmployeeManager.Setup(manager => manager.SaveEmployeeToFile(employee)).Throws(new FileIOException("Error saving to file"));

        // Act and Assert
        Assert.Throws<FileIOException>(() => mockEmployeeManager.Object.SaveEmployeeToFile(employee));
    }
}
