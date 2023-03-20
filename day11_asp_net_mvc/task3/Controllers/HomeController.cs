using Microsoft.AspNetCore.Mvc;

namespace task3.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}