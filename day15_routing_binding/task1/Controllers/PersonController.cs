using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using task1.ViewModels;

namespace task1.Controllers;

public class PersonController : Controller
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int? id, string? name)
    {
        if (id != null) ViewBag.Id = id;
        if (name != null) ViewBag.Name = name;
        return View();
    }

    public IActionResult Find(string firstName, string lastName)
    {
        ViewBag.FirstName = firstName;
        ViewBag.LastName = lastName;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}