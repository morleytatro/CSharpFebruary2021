using Microsoft.AspNetCore.Mvc;

using ViewModels.Models; // so that we can use VideoGame

namespace ViewModels.Controllers
{
    public class VideoGamesController : Controller
    {
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
    }
}