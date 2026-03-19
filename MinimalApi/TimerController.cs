using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("time")]
public class TimeController : ControllerBase
{
    [HttpGet("utc")]
    public IActionResult GetUtcTime()
    {
        return Ok(DateTime.UtcNow);
    }
}