using Moq;

namespace CH06_UnitTesting.NUnit.Tests;

[TestFixture]
public class OrderServiceTests
{
    [Test]
    public void GetOrderById_ReturnsOrder_WhenOrderExists()
    {
        // Arrange
        var orderRepository = new Mock<IOrderRepository>();
        orderRepository.Setup(repo => repo.GetById(1))
            .Returns(new Order { Id = 1, CustomerName = "John Doe" });
        var orderService = new OrderService(orderRepository.Object);

        // Act
        var result = orderService.GetOrderById(1);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Id);
        Assert.AreEqual("John Doe", result.CustomerName);
    }

    [Test]
    public void GetOrderById_TotalPrice_ReturnsCorrectValue()
    {
        // Create a mock Order object
        var mockOrder = new Mock<Order>();

        // Set up the behavior of the TotalPrice property
        mockOrder.SetupGet(o => o.TotalPrice).Returns(10.0);

        // Call the method being tested, passing in the mock Order object
        var totalPrice = CalculateTotalPrice(mockOrder.Object);

        // Verify that the method returned the expected total price
        Assert.AreEqual(10.0, totalPrice);

    }

    private double CalculateTotalPrice(Order @object)
    {
        return @object.TotalPrice;
    }
}
