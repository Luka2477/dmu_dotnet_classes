using Microsoft.AspNetCore.Mvc;

namespace task2.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        string name = "Lukas";
        int age = 23;
        DateTime birthday = new DateTime(2000, 02, 19);

        ViewBag.Name = name;
        ViewBag.Age = age;
        ViewBag.Birthday = birthday;
        
        return View();
    }
}