using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace WebApiVersioning.Controllers.V2;


[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[Route("api/[controller]")]
[ApiVersion("2.0")]
public class UserController : ControllerBase
{
    [MapToApiVersion("2.0")]
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("V2");
    }
}
