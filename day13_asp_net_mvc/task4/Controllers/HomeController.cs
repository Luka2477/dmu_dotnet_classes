using Microsoft.AspNetCore.Mvc;
using task4.Models;

namespace task4.Controllers;

public class HomeController : Controller
{
    // GET
    // public IActionResult Index()
    // {
    //     Book book = new()
    //     {
    //         Author = "Steve Turner",
    //         ImageUrl = "book_0060844094.jpg",
    //         ISBN = "0060844094",
    //         Price = 150,
    //         Published = 2005,
    //         Publisher = "It Books",
    //         Title = "A Hard Day's Write: The Stories Behind Every Beatles Song"
    //     };
    //     MusicCD musicCd = new()
    //     {
    //         ImageUrl = "cd_abbey_road_remastered.jpg",
    //         Title = "Abbey Road (Remastered)",
    //         Price = 128,
    //         Artist = "Beatles",
    //         Published = 2009,
    //         Publisher = "EMI",
    //         Tracks =
    //         {
    //             "Come Together",
    //             "Something",
    //             "Maxwell's Silver Hammer",
    //             "Oh! Darling",
    //             "Octopus's Garden",
    //             "I Want You (She's So Heavy)",
    //             "Here Comes The Sun",
    //             "Because",
    //             "You Never Give Me Your Money",
    //             "Sun King",
    //             "Mean Mr. Mustard",
    //             "Polythene Pam",
    //             "She Came In Through The Bedroom Window",
    //             "Golden Slumbers",
    //             "Carry That Weight",
    //             "The End",
    //             "Her Majesty"
    //         }
    //     };
    //
    //     ViewBag.Book = book;
    //     ViewBag.MusicCD = musicCd;
    //     return View();
    // }

    // GET
    public IActionResult Index()
    {
        ViewBag.Book1 = new Book("A Hard Day's Write: The Stories Behind Every Beatles Song", 150, "It Books", 2005,
            "Steve Turner")
        {
            ISBN = "0060844094",
            ImageUrl = "book_0060844094.jpg"
        };
        ViewBag.MusicCD1 = new MusicCD("Abbey Road (Remastered)", 128, "EMI", 2009, "Beatles")
        {
            ImageUrl = "cd_abbey_road_remastered.jpg",
            Tracks = new List<string>
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

        ViewBag.Book2 = new Book("With a Little Help from My Friends: The Making of Sgt. Pepper", 180,
            "Little Brown & Co", 0, "George Martin")
        {
            ISBN = "0316547832",
            ImageUrl = "book_0316547832.jpg"
        };
        ViewBag.MusicCD2 = new MusicCD("Revolver (Remastered)", 128, "EMI", 2009, "The Beatles")
        {
            ImageUrl = "cd_revolver_remastered.jpg",
            Tracks = new List<string>
            {
                "Taxman",
                "Eleanor Rigby",
                "I'm Only Sleeping",
                "Love You To", 
                "Here, There And Everywhere",
                "Yellow Submarine",
                "She Said She Said",
                "Good Day Sunshine",
                "And Your Bird Can Sing",
                "For No One",
                "Doctor Robert",
                "I Want To Tell You",
                "Got To Get You Into My Life",
                "Tomorrow Never Knows"
            }
        };

        return View();
    }
}