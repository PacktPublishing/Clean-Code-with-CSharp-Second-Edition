using CH07.Controllers;
using CH07.Models;
using Microsoft.AspNetCore.Mvc;

namespace CH07.Tests;

public class MyControllerTests
{
    [Fact]
    public void Get_ReturnOkResult()
    {
        // Arrange
        var controller = new MyController();
        // Act
        var result = controller.Get();
        // Assert
        Assert.IsType<OkResult>(result);
    }

    [Fact]
    public void Post_WithValidModel_ReturnsCreatedAtActionResult()
    {
        // Arrange
        var controller = new MyController();
        var validModel = new MyModel { Name = "John Doe", Email = "john.doe@example.com" };
        // Act
        var result = controller.Post(validModel);
        // Assert
        var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
        Assert.Equal("ActionName", createdAtActionResult.ActionName);
    }

}
