using Microsoft.AspNetCore.Mvc;
using task3.Models;

namespace task3.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        Book book = new()
        {
            Author = "Steve Turner",
            ImageUrl = "book_0060844094.jpg",
            ISBN = "0060844094",
            Price = 150,
            Published = 2005,
            Publisher = "It Books",
            Title = "A Hard Day's Write: The Stories Behind Every Beatles Song"
        };
        MusicCD musicCd = new()
        {
            ImageUrl = "cd_abbey_road_remastered.jpg",
            Title = "Abbey Road (Remastered)",
            Price = 128,
            Artist = "Beatles",
            Published = 2009,
            Publisher = "EMI",
            Tracks =
            {
                "Come Together",
                "Something",
                "Maxwell's Silver Hammer",
                "Oh! Darling",
                "Octopus's Garden",
                "I Want You (She's So Heavy)",
                "Here Comes The Sun",
                "Because",
                "You Never Give Me Your Money",
                "Sun King",
                "Mean Mr. Mustard",
                "Polythene Pam",
                "She Came In Through The Bedroom Window",
                "Golden Slumbers",
                "Carry That Weight",
                "The End",
                "Her Majesty"
            }
        };

        ViewBag.Book = book;
        ViewBag.MusicCD = musicCd;
        return View();
    }
}