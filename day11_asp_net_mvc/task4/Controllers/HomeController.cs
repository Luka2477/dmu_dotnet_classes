using Microsoft.AspNetCore.Mvc;

namespace task4.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}