using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace WebApiVersioning.Controllers.V1;


[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[Route("api/[controller]")]
[ApiVersion("1.0")]
public class UserController : ControllerBase
{
    [MapToApiVersion("1.0")]
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("V1");
    }
}
