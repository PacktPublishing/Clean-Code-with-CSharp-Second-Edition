using CH07.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CH07.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // Requires authentication for all actions in this controller.
public class MyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Post([FromBody] MyModel model)
    {
        return Ok();
    }
}
