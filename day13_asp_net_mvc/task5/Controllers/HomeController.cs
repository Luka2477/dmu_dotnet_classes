using Microsoft.AspNetCore.Mvc;
using task5.Models;

namespace task5.Controllers;

public class HomeController : Controller
{
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
            Tracks = new List<Track>
            {
                new("Come Together", "Lennon", "00:04:19"),
                new("Something", "Harrison", "00:03:02"),
                new("Maxwell's Silver Hammer", "McCartney", "00:03:27"),
                new("Oh! Darling", "McCartney", "00:03:27"),
                new("Octopus's Garden", "Starr", "00:02:51"),
                new("I Want You (She's So Heavy)", "Lennon", "00:07:47"),
                new("Here Comes The Sun", "Harrison", "00:03:05"),
                new("Because", "Lennon, McCartney, Harrison", "00:02:45"),
                new("You Never Give Me Your Money", "McCartney", "00:04:03"),
                new("Sun King", "Lennon, McCartney, Harrison", "00:02:26"),
                new("Mean Mr. Mustard", "Lennon", "00:01:06"),
                new("Polythene Pam", "Lennon", "00:01:13"),
                new("She Came In Through The Bedroom Window", "McCartney", "00:01:58"),
                new("Golden Slumbers", "McCartney", "00:01:31"),
                new("Carry That Weight", "McCartney, Lennon, Harrison, Starr", "00:01:36"),
                new("The End", "McCartney", "00:02:05"),
                new("Her Majesty", "McCartney", "00:00:23")
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
            Tracks = new List<Track>
            {
                new("Taxman", "Harrison", "00:02:36"),
                new("Eleanor Rigby", "McCartney", "00:02:11"),
                new("I'm Only Sleeping", "Lennon", "00:03:02"),
                new("Love You To", "Harrison", "00:03:00"),
                new("Here, There And Everywhere", "McCartney", "00:02:29"),
                new("Yellow Submarine", "Starr", "00:02:40"),
                new("She Said She Said", "Lennon", "00:02:39"),
                new("Good Day Sunshine", "McCartney", "00:02:08"),
                new("And Your Bird Can Sing", "Lennon", "00:02:02"),
                new("For No One", "McCartney", "00:02:03"),
                new("Doctor Robert", "Lennon", "00:02:14"),
                new("I Want To Tell You", "Harrison", "00:02:30"),
                new("Got To Get You Into My Life", "McCartney", "00:02:31"),
                new("Tomorrow Never Knows", "Lennon", "00:03:00")
            }
        };

        return View();
    }
}