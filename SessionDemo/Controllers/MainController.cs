using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SessionDemo.Controllers
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            int? favNumber = HttpContext.Session.GetInt32("FavNumber");

            ViewBag.FavNumber = favNumber;
            return View();
        }

        [HttpPost("pick-favorite-number")]
        public IActionResult PickFavoriteNumber(int number)
        {
            Console.WriteLine(number);
            HttpContext.Session.SetInt32("FavNumber", number);
            return RedirectToAction("Index");
        }

        [HttpPost("reset")]
        public IActionResult ResetNumber()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}