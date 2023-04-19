using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using task2.Models;
using task2.ViewModels;

namespace task2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private IEnumerable<PersonModel> AllPersons()
    {
        return new PersonModel[]
        {
            new(new PersonModel.Name("Lukas", "Knudsen"), 23),
            new(new PersonModel.Name("Mads", "Bjerg"), 26),
            new(new PersonModel.Name("Mike", "Bang"), 25),
            new(new PersonModel.Name("Berta", "Vazquez"), 21)
        };
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult ShowAll()
    {
        return View(AllPersons());
    }

    [HttpGet]
    public IActionResult ShowOne()
    {
        return View(AllPersons().ToList()[0]);
    }

    // -----------------------------------------------------------------------------------------------------------------

    [HttpGet]
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}