﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using task1.Models;
using task1.ViewModels;

namespace task1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Sale()
    {
        return View();
    }

    [HttpGet]
    public IActionResult MoreSales()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Buy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult BuyAndSell()
    {
        return View();
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