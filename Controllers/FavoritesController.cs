using Microsoft.AspNetCore.Mvc;
using OlympicGames.Models;
using OlympicGames.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace OlympicGames.Controllers
{
    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            var favorites = HttpContext.Session.GetObjectFromJson<List<Country>>("Favorites") ?? new List<Country>();
            return View(favorites);
        }

        [HttpPost]
        public IActionResult AddToFavorites(int countryId)
        {
            var country = CountryData.Countries.FirstOrDefault(c => c.Id == countryId);
            if (country != null)
            {
                var favorites = HttpContext.Session.GetObjectFromJson<List<Country>>("Favorites") ?? new List<Country>();
                favorites.Add(country);
                HttpContext.Session.SetObjectAsJson("Favorites", favorites);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult ClearFavorites()
        {
            HttpContext.Session.Remove("Favorites");
            return RedirectToAction("Index");
        }
    }
}
