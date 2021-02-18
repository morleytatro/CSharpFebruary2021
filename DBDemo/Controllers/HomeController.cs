using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DBDemo.Models;

namespace DBDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Hats = _context
                .Hats;
                // .Where(hat => hat.Color == "Blue");

            return View();
        }

        // {id} is a routing parameter which will allow us to find one
        [HttpGet("hats/{id}")]
        public IActionResult SingleHatPage(int id)
        {
            ViewBag.SingleHat = _context
                .Hats
                .FirstOrDefault(hat => hat.HatId == id);

            return View();
        }

        // method to show the form
        [HttpGet("hats/new")]
        public IActionResult NewHatPage()
        {
            return View();
        }

        // method to process the form
        [HttpPost("create-hat")]
        public IActionResult CreateHat(Hat hatToCreate)
        {
            if(ModelState.IsValid)
            {
                // add to the DB
                _context.Add(hatToCreate);

                _context.SaveChanges(); // this actually persists it to the DB
            }

            return RedirectToAction("Index");
        }

        // this is our edit page
        [HttpGet("hats/{hatId}/edit")]
        public IActionResult EditHatPage(int hatId)
        {
            Hat hatToEdit = _context
                .Hats
                .FirstOrDefault(hat => hat.HatId == hatId);

            // passing it as a ViewModel
            return View(hatToEdit);
        }

        // method for processing the edit form
        [HttpPost("update-hat")]
        public IActionResult UpdateHat(Hat updatedHat) // this is coming from the form
        {
            var hatToUpdate = _context
                .Hats
                .FirstOrDefault(hat => hat.HatId == updatedHat.HatId);
            
            // set each property individually
            hatToUpdate.Color = updatedHat.Color;
            hatToUpdate.Brand = updatedHat.Brand;
            hatToUpdate.Adjustable = updatedHat.Adjustable;

            _context.SaveChanges(); // persist to the DB

            // return RedirectToAction("SingleHatPage", new { id = updatedHat.HatId });
            return Redirect($"/hats/{updatedHat.HatId}");
        }

        // method for deleting hats
        [HttpGet("hats/{hatId}/delete")]
        public IActionResult DeleteHat(int hatId)
        {
            var hatToDelete = _context.Hats.First(hat => hat.HatId == hatId);

            _context.Hats.Remove(hatToDelete);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
