using Microsoft.AspNetCore.Mvc;

namespace warmup_task1.Controllers;

public class DiceRollerController : Controller
{
    // GET
    public IActionResult Index()
    {
        ViewBag.Roll = new Random().Next(1, 7);
        return View();
    }
}