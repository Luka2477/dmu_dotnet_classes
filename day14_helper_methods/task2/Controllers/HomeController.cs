using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using task2.Models;

namespace task2.Controllers;

public class HomeController : Controller
{
    private ParkingTicketMachine _parkingTicketMachine = new();

    [HttpGet]
    public IActionResult Index()
    {
        return View(_parkingTicketMachine);
    }

    [HttpPost]
    public IActionResult Index(IFormCollection formData)
    {
        _parkingTicketMachine.InsertCoin(int.Parse(formData["AmountInserted"].ToString()));
        
        if (formData.ContainsKey("coin"))
        {
            _parkingTicketMachine.InsertCoin(int.Parse(formData["coin"].ToString()));
        }

        return View(formData.ContainsKey("action") ? formData["action"].ToString() : "Index",_parkingTicketMachine);
    }
}