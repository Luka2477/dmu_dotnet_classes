﻿using Microsoft.AspNetCore.Mvc;

namespace task2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}