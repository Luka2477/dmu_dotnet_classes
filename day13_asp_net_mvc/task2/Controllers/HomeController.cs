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
            new("Lukas", "Knudsen", "Something 1", "8000", "Aarhus")
            {
                PhoneNumbers =
                {
                    "12345678",
                    "11223344"
                },
                Birthday = new DateTime(2000, 02, 19)
            },
            new("Berta", "Vazquez", "Something 2", "8000", "Aarhus")
            {
                PhoneNumbers =
                {
                    "98765432"
                }
            }
        };
        return View();
    }
}