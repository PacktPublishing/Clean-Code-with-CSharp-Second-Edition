namespace CH06_UnitTesting.MSTest.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Add_ShouldReturnSumOfTwoNumbers()
    {
        // Arrange
        Calculator calculator = new ();
        int num1 = 5;
        int num2 = 7;

        // Act
        int result = calculator.Add (num1, num2);

        // Assert
        Assert.AreEqual(12, result);
    }
}
