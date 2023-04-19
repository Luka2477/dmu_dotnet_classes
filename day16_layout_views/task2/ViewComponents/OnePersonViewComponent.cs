using Microsoft.AspNetCore.Mvc;
using task2.Models;

namespace task2.ViewComponents;

public class OnePersonViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(PersonModel p)
    {
        if (p.Age < 18)
        {
            p.FullName.Last = p.FullName.Last.Replace(p.FullName.Last, new string('*', p.FullName.Last.Length));
        }

        return View(p);
    }
}