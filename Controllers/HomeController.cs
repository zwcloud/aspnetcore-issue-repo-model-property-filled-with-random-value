using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[ApiController]
[Route("/")]
public class HomeController : Controller
{
    [HttpGet("GetRequest")]
    public IActionResult GetRequest([FromQuery]string number, [FromQuery]RequestId requestId)
    {
        Debug.WriteLine("number = " + number);
        Debug.WriteLine("RequestId = " + requestId);
        return View("Request", requestId);
    }

    [HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }
}
