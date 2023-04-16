using CH5_ExceptionHandling;

namespace CH5_ExceptionHandling.Tests;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Divide_ThrowsDivideByZeroException()
    {
        // Arrange
        int numerator = 10;
        int denominator = 0;

        Calculator calculator = new();

        // Act and Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(numerator, denominator));
    }
}
