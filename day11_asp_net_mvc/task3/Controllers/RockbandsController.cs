using Microsoft.AspNetCore.Mvc;

namespace task3.Controllers;

public class RockbandsController : Controller
{
    // GET
    public IActionResult Index()
    {
        string[] favRockbands =
        {
            "Skillet", "Slipknot", "KISS", "Nickleback", "Disturbed", "Led Zeplin", "Fall Out Boys", "The Beatles",
            "Something1", "Something2"
        };
        ViewBag.FavRockbands = favRockbands;
        return View();
    }
}