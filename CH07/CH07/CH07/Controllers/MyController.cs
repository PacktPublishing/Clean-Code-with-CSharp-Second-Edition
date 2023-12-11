using CH07.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CH07.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // Requires authentication for all actions in this controller.
public class MyController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Post([FromBody] MyModel model)
    {
        return CreatedAtAction("ActionName", new MyModel { Name = "John Doe", Email = "john.doe@example.com" });
    }
}
