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
        return View();
    }

    [HttpPost]
    public IActionResult CreateCollection(IFormCollection formData)
    {
        return View("Created",
            new PersonModel(new PersonModel.IName
                {
                    First = formData["Name.First"],
                    Last = formData["Name.Last"]
                },
                int.Parse(formData["Age"])
            )
        );
    }

    [HttpPost]
    public IActionResult CreateSimpleTypes(PersonModel.IName Name, int Age)
    {
        return View("Created",
            new PersonModel(new PersonModel.IName
                {
                    First = Name.First,
                    Last = Name.Last
                },
                Age
            )
        );
    }

    [HttpPost]
    public IActionResult CreateModel(PersonModel person)
    {
        return View("Created", person);
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