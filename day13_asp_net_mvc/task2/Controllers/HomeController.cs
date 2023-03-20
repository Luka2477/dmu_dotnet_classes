using Microsoft.AspNetCore.Mvc;
using task2.Models;

namespace task2.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        ViewBag.Persons = new List<Person>
        {
            new("Lukas", "Knudsen", "Something 1", "8000", "Aarhus"),
            new("Berta", "Vazquez", "Something 2", "8000", "Aarhus")
        };
        return View();
    }
}