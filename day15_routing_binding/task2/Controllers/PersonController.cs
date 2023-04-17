using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using task2.Models;
using task2.ViewModels;

namespace task2.Controllers;

public class PersonController : Controller
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index(int? id, string? name)
    {
        if (id != null) ViewBag.Id = id;
        if (name != null) ViewBag.Name = name;
        return View();
    }

    [HttpGet]
    public IActionResult Find(string firstName, string lastName)
    {
        ViewBag.FirstName = firstName;
        ViewBag.LastName = lastName;
        return View();
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View(new PersonModel(new PersonModel.IName { First = "Lukas", Last = "Knudsen"}, 23));
    }

    [HttpPost]
    public IActionResult Create(PersonModel person)
    {
        Console.WriteLine(person);
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