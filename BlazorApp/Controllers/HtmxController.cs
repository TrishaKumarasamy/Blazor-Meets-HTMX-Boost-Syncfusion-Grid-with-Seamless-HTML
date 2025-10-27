using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
public class HtmxController : Controller
{
    [HttpGet("message")]
    public IActionResult GetMessage()
    {
        return Content("<p>Update from HTMX!</p>", "text/html");
    }
}