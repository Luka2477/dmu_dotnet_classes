using Microsoft.AspNetCore.Mvc;
using task1.Models;

namespace task1.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        ViewBag.Glass = new Product("Wine glass", 66.95, "grandcru.jpg", "Something");
        ViewBag.Bin = new Product("Bin", 19.95, "bin_35l.jpg", "Something");
        ViewBag.Knife = new Product("Knife", 99.95, "st_knife.jpg", "Something");
        return View();
    }
}