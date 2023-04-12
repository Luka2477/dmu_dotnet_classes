using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

namespace task1.Controllers;

public class HomeController : Controller
{
    private List<SelectListItem> _countries
    {
        get
        {
            List<SelectListItem> countries = HttpContext.Session.GetObject<List<SelectListItem>>("Countries");
            if (countries != null) return countries;

            countries = new()
            {
                new SelectListItem { Text = "China", Value = "CN" },
                new SelectListItem { Text = "Denmark", Value = "DK" },
                new SelectListItem { Text = "United Kingdom", Value = "UK" }
            };
            HttpContext.Session.SetObject("Countries", countries);
            return countries;
        }
        set => HttpContext.Session.SetObject("Countries", value);
    }

    [HttpGet]
    public IActionResult Index(string countryCode)
    {
        ViewBag.Countries = _countries;
        ViewBag.CountryCode = countryCode;

        return View();
    }

    [HttpPost]
    public IActionResult Index(IFormCollection formData)
    {
        var countries = _countries;
        countries.Add(new SelectListItem { Text = formData["country"], Value = formData["code"] });
        _countries = countries;
        
        ViewBag.Countries = countries;

        bool hasCountryCode = formData.TryGetValue("countryCode", out StringValues countryCodes);
        if (hasCountryCode) ViewBag.CountryCode = countryCodes[0]!;
        
        return View();
    }
}

public static class SessionExtensions
{
    public static void SetObject(this ISession session, string key, object value)
    {
        session.SetString(key, JsonConvert.SerializeObject(value));
    }

    public static T GetObject<T>(this ISession session, string key)
    {
        var value = session.GetString(key);
        return value == null ? default : JsonConvert.DeserializeObject<T>(value);
    }
}