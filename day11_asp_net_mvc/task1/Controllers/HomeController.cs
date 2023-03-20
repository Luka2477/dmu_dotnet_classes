using Microsoft.AspNetCore.Mvc;

namespace task1.Controllers;

public class HomeController : Controller
{
    // GET: Home
    public IActionResult Index()
    {
        return View();
    }
}