using System;
using Microsoft.AspNetCore.Mvc;

using ViewModels.Models; // so that we can use VideoGame

namespace ViewModels.Controllers
{
    public class VideoGamesController : Controller
    {
        // all our functions are "actions"

        [HttpGet("")]
        public ViewResult Index() // name should match the View name
        {
            // context = {
            //     "games": [
            //         "Halo",
            //         "Half Life 2",
            //         "Hyperlight Drifter",
            //         "Cyberpunk 2077"
            //     ]
            // }

            // return render(Request, "games.html", context)

            // ViewBag.Games = new string[] {
            //     "Halo",
            //     "Half Life 2",
            //     "Hyperlight Drifter",
            //     "Cyberpunk 2077"
            // };
            var games = new VideoGame[]
            {
                new VideoGame
                {
                    Title = "Halo",
                    ReleaseDate = "2001",
                    MultiPlayer = true,
                    Developer = "Microsoft",
                    Rating = 10
                }
            };

            ViewBag.MyName = "Morley Tatro";

            // ViewBag.User = new {
            //     FirstName = "Morley",
            //     LastName = "Tatro"
            // };

            return View(games);
        }

        [HttpGet("new-video-game")]
        // show the user a form to submit one
        // note that we're returning an object
        // that implements the IActionResult interface
        // show the form
        public IActionResult NewVideoGame()
        {
            return View();
        }

        // process the form
        [HttpPost("create-video-game")]
        public IActionResult CreateVideoGame(VideoGame newGame)
        {
            if(ModelState.IsValid)
            {
                // met validations
                Console.WriteLine(newGame.Title);
                return View(newGame);
            }
            else
            {
                return View("NewVideoGame");
            }

        }
    }
}