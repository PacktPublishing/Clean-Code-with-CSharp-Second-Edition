using Moq;

namespace CH06_UnitTesting.xUnit.Tests;

public class MathServiceTests
{
    [Fact]
    public void AddNumbers_ShouldReturnSum_WhenUsingMockedCalculator()
    {
        // Arrange
        var calculatorMock = new Mock<ICalculator>();
        calculatorMock.Setup(calculator => calculator.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a + b);
        var mathService = new MathService(calculatorMock.Object);
        
        // Act
        int result = mathService.AddNumbers(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}
