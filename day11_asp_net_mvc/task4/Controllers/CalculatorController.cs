using Microsoft.AspNetCore.Mvc;

namespace task4.Controllers;

public class CalculatorController : Controller
{
    [HttpGet]
    public IActionResult TimeCalculator()
    {
        return View();
    }

    [HttpPost]
    public IActionResult TimeCalculator(IFormCollection formCollection)
    {
        int hours = Convert.ToInt32(formCollection["Hours"]);
        int minutes = Convert.ToInt32(formCollection["Minutes"]);
        int seconds = Convert.ToInt32(formCollection["Seconds"]);

        double totalSeconds = new TimeSpan(0, hours, minutes, seconds).TotalSeconds;

        ViewBag.Hours = hours;
        ViewBag.Minutes = minutes;
        ViewBag.Seconds = seconds;
        ViewBag.TotalSeconds = totalSeconds;
        return View();
    }
}